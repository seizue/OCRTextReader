using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OCRTextReader
{
    public static class TesseractInstaller
    {
        private const string GitHubApiLatest =
            "https://api.github.com/repos/UB-Mannheim/tesseract/releases/latest";

        private const string FallbackInstallerUrl =
            "https://github.com/UB-Mannheim/tesseract/releases/download/v5.4.0.20240606/tesseract-ocr-w64-setup-5.4.0.20240606.exe";

        private static readonly string[] KnownInstallPaths = new[]
        {
            @"C:\Program Files\Tesseract-OCR\tessdata",
            @"C:\Program Files (x86)\Tesseract-OCR\tessdata"
        };

        public static bool EnsureInstalled()
        {
            if (IsTesseractInstalled())
                return true;

            var result = MessageBox.Show(
                "Tesseract OCR is not installed on this system.\n\n" +
                "Tesseract is required to extract text from images.\n\n" +
                "Would you like to download and install it now?\n" +
                "(~50 MB download, requires administrator privileges)",
                "Tesseract OCR Not Found",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return false;

            return DownloadAndInstall();
        }

        public static bool IsTesseractInstalled()
        {
            // #40: KnownInstallPaths are hardcoded absolute paths — no silent drop risk
            return Array.Exists(KnownInstallPaths,
                path => File.Exists(path + @"\eng.traineddata"));
        }

        private static string ResolveInstallerUrl()
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "OCRTextReader");
                    string json = client.DownloadString(GitHubApiLatest);

                    var match = Regex.Match(json,
                        @"""browser_download_url""\s*:\s*""(https://github\.com/UB-Mannheim/tesseract/releases/download/[^""]*w64-setup[^""]*\.exe)""");

                    if (match.Success)
                        return match.Groups[1].Value;
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Trace.TraceWarning("Tesseract URL resolution failed (network): {0}", ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                System.Diagnostics.Trace.TraceWarning("Tesseract URL resolution failed (parse): {0}", ex.Message);
            }

            return FallbackInstallerUrl;
        }

        private static bool DownloadAndInstall()
        {
            // #27: second arg is a literal string — no rooted segment, no silent drop
            string tempInstaller = Path.Combine(Path.GetTempPath(), "tesseract-setup.exe");

            try
            {
                string installerUrl = ResolveInstallerUrl();

                using (var progress = new DownloadProgressForm())
                {
                    progress.Show();
                    Application.DoEvents();

                    using (var client = new WebClient())
                    {
                        client.DownloadProgressChanged += (s, e) =>
                        {
                            progress.UpdateProgress(e.ProgressPercentage,
                                $"Downloading Tesseract installer... {e.ProgressPercentage}%");
                            Application.DoEvents();
                        };

                        client.DownloadFileCompleted += (s, e) =>
                        {
                            progress.UpdateProgress(100, "Download complete. Launching installer...");
                            Application.DoEvents();
                        };

                        var task = client.DownloadFileTaskAsync(installerUrl, tempInstaller);
                        while (!task.IsCompleted)
                        {
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(50);
                        }

                        if (task.IsFaulted)
                            throw task.Exception?.InnerException ?? new Exception("Download failed.");
                    }

                    progress.Close();
                }

                var psi = new ProcessStartInfo
                {
                    FileName = tempInstaller,
                    Arguments = "/S",
                    UseShellExecute = true,
                    Verb = "runas"
                };

                var proc = Process.Start(psi);
                if (proc == null)
                    throw new InvalidOperationException("Failed to start the installer process.");

                bool finished = proc.WaitForExit(180_000);
                if (!finished)
                {
                    MessageBox.Show(
                        "The installer is taking longer than expected.\n" +
                        "Please wait for it to finish, then restart the application.",
                        "Installation In Progress",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return false;
                }

                if (IsTesseractInstalled())
                {
                    MessageBox.Show(
                        "Tesseract OCR installed successfully!\n\n" +
                        "You can now use OCR to extract text from images.",
                        "Installation Complete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return true;
                }

                MessageBox.Show(
                    "The installer finished but Tesseract could not be detected.\n\n" +
                    "Please try installing manually from:\n" +
                    "https://github.com/UB-Mannheim/tesseract/wiki",
                    "Installation Issue",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex) when (ex is WebException || ex is InvalidOperationException || ex is IOException)
            {
                MessageBox.Show(
                    $"Failed to install Tesseract automatically.\n\n" +
                    $"Error: {ex.Message}\n\n" +
                    "Please install manually from:\n" +
                    "https://github.com/UB-Mannheim/tesseract/wiki",
                    "Installation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                try
                {
                    if (File.Exists(tempInstaller))
                        File.Delete(tempInstaller);
                }
                catch (IOException ex)
                {
                    System.Diagnostics.Trace.TraceWarning("Could not delete temp installer: {0}", ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    System.Diagnostics.Trace.TraceWarning("Could not delete temp installer: {0}", ex.Message);
                }
            }
        }
    }
}

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OCRTextReader
{
    public partial class Main : Form
    {
        private string selectedImagePath = string.Empty;
        private string extractedText = string.Empty;

        public Main()
        {
            InitializeComponent();
            txtExtractedText.SelectionStart = txtExtractedText.Text.Length;
            btnProcessOCR.Enabled = false;
            btnExportToWord.Enabled = false;
        }

        private void btnSelectDocOrImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                lblImagePath.Text = Path.GetFileName(selectedImagePath);

                try
                {
                    string extension = Path.GetExtension(selectedImagePath).ToLowerInvariant();

                    if (extension is ".jpg" or ".jpeg" or ".png" or ".bmp" or ".gif" or ".tiff")
                    {
                        pictureBox.Image = Image.FromFile(selectedImagePath);
                        btnProcessOCR.Enabled = true;
                        lblStatus.Text = "Image loaded. Click 'Extract Text' to process.";
                        lblStatus.ForeColor = Color.MediumSeaGreen;
                    }
                    else
                    {
                        pictureBox.Image = Properties.Resources.image_document_240px;
                        btnProcessOCR.Enabled = true;
                        lblStatus.Text = $"{extension.ToUpperInvariant().TrimStart('.')} file selected. Click 'Extract Text' to process.";
                        lblStatus.ForeColor = Color.MediumSeaGreen;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Error loading file.";
                    lblStatus.ForeColor = Color.Salmon;
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Error loading file.";
                    lblStatus.ForeColor = Color.Salmon;
                }
            }
        }

        private async void btnProcessOCR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedImagePath) || !File.Exists(selectedImagePath))
            {
                MessageBox.Show("Please select a file first.", "No File Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnProcessOCR.Enabled = false;
            btnProcessOCR.Text = "Processing...";
            string extension = Path.GetExtension(selectedImagePath).ToLowerInvariant();
            string fileType = extension switch
            {
                ".pdf" => "PDF",
                ".xlsx" or ".xls" => "Excel",
                ".pptx" or ".ppt" => "PowerPoint",
                _ => "image"
            };
            lblStatus.Text = $"Extracting text from {fileType} file... Please wait.";
            lblStatus.ForeColor = Color.Orange;
            Application.DoEvents();

            try
            {
                if (extension is ".pdf" or ".xlsx" or ".pptx")
                {
                    var documentService = new DocumentTextExtractorService();
                    extractedText = await documentService.ExtractTextAsync(selectedImagePath);
                }
                else if (extension is ".xls" or ".ppt")
                {
                    string fileTypeName = extension == ".xls" ? "Excel" : "PowerPoint";
                    string newFormat = extension == ".xls" ? ".xlsx" : ".pptx";

                    MessageBox.Show(
                        $"Legacy {extension.ToUpperInvariant()} format is not supported.\n\n" +
                        $"To extract text from this file, please:\n" +
                        $"1. Open the file in Microsoft {fileTypeName}\n" +
                        $"2. Click 'File' → 'Save As'\n" +
                        $"3. Choose '{newFormat.ToUpperInvariant()}' format\n" +
                        $"4. Save and try again with the new file",
                        "Unsupported File Format",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    lblStatus.Text = $"Legacy {extension.ToUpperInvariant()} format not supported. Please convert to {newFormat.ToUpperInvariant()}.";
                    lblStatus.ForeColor = Color.Orange;
                    return;
                }
                else
                {
                    var ocrService = new OCRService();
                    extractedText = await ocrService.ExtractTextAsync(selectedImagePath);
                }

                if (!string.IsNullOrEmpty(extractedText))
                {
                    txtExtractedText.Text = extractedText;
                    btnExportToWord.Enabled = true;
                    lblStatus.Text = $"Text extracted successfully! ({extractedText.Length} characters)";
                    lblStatus.ForeColor = Color.MediumSeaGreen;
                }
                else
                {
                    txtExtractedText.Text = "No text could be extracted from the file.";
                    lblStatus.Text = "No text found in the file.";
                    lblStatus.ForeColor = Color.LightGoldenrodYellow;
                }
            }
            catch (InvalidOperationException ex)
            {
                string errorMessage = extension is ".pdf" or ".xlsx" or ".pptx"
                    ? $"An error occurred while extracting text from the {fileType} document.\n\nDetails: {ex.Message}"
                    : $"An error occurred during OCR processing.\n\nDetails: {ex.Message}\n\n" +
                      "Make sure Tesseract data files are installed.\n" +
                      "See README.md for installation instructions.";

                MessageBox.Show(errorMessage, "Extraction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error during text extraction.";
                lblStatus.ForeColor = Color.Salmon;
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show($"Unsupported file format.\n\nDetails: {ex.Message}",
                    "Extraction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error during text extraction.";
                lblStatus.ForeColor = Color.Salmon;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"File access error.\n\nDetails: {ex.Message}",
                    "Extraction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error during text extraction.";
                lblStatus.ForeColor = Color.Salmon;
            }
            finally
            {
                btnProcessOCR.Enabled = true;
                btnProcessOCR.Text = "Extract Text";
            }
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(extractedText))
            {
                MessageBox.Show("No text to export. Please extract text first.",
                    "No Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog.FileName = !string.IsNullOrEmpty(selectedImagePath)
                ? $"{Path.GetFileNameWithoutExtension(selectedImagePath)}_extracted.docx"
                : "extracted_text.docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var wordService = new WordExportService();
                    wordService.ExportToWord(extractedText, saveFileDialog.FileName,
                        Path.GetFileName(selectedImagePath));

                    lblStatus.Text = $"Text exported successfully to: {Path.GetFileName(saveFileDialog.FileName)}";
                    lblStatus.ForeColor = Color.Green;
                    MessageBox.Show($"Text successfully exported to:\n{saveFileDialog.FileName}",
                        "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error exporting to Word: {ex.Message}",
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Error exporting to Word.";
                    lblStatus.ForeColor = Color.Salmon;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"Error exporting to Word: {ex.Message}",
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Error exporting to Word.";
                    lblStatus.ForeColor = Color.Salmon;
                }
            }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            lblImagePath.Text = "";
            txtExtractedText.Text = "";
            pictureBox.Image = Properties.Resources.image_document_240px;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/seizure/OCRTextReader",
                UseShellExecute = true
            });
        }
    }
}

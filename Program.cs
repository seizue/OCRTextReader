using System;
using System.Windows.Forms;

namespace OCRTextReader
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ensure Tesseract is installed before launching the main window.
            // If not found, the user is prompted to download and install it automatically.
            TesseractInstaller.EnsureInstalled();

            Application.Run(new Main());
        }
    }
}


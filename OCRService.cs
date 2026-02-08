using System;
using System.IO;
using System.Threading.Tasks;
using Tesseract;

namespace OCRTextReader
{
    public class OCRService
    {
        private string tessdataPath;

        public OCRService()
        {
            // Try to find tessdata directory
            // Common locations for Tesseract data files
            string[] possiblePaths = new[]
            {
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Tesseract-OCR", "tessdata"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Tesseract-OCR", "tessdata"),
                @"C:\Program Files\Tesseract-OCR\tessdata",
                @"C:\Program Files (x86)\Tesseract-OCR\tessdata"
            };

            foreach (var path in possiblePaths)
            {
                if (Directory.Exists(path))
                {
                    tessdataPath = path;
                    break;
                }
            }

            // If not found, use current directory
            if (string.IsNullOrEmpty(tessdataPath))
            {
                tessdataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");
            }
        }

        public async Task<string> ExtractTextAsync(string imagePath)
        {
            return await Task.Run(() => ExtractText(imagePath));
        }

        public string ExtractText(string imagePath)
        {
            try
            {
                using (var engine = new TesseractEngine(tessdataPath, "eng", EngineMode.Default))
                {
                    // Configure OCR settings for better accuracy
                    engine.SetVariable("tessedit_char_whitelist", 
                        "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz .,!?;:()[]{}\"'-_/@#$%&*+=<>|\\~`");
                    
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            string text = page.GetText();
                            return text?.Trim() ?? string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"OCR processing failed: {ex.Message}\n\n" +
                    "Please ensure:\n" +
                    "1. Tesseract OCR is installed on your system\n" +
                    "2. English language data files (eng.traineddata) are available in the tessdata folder\n" +
                    "3. The tessdata folder path is correct", ex);
            }
        }
    }
}


using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tesseract;

namespace OCRTextReader
{
    public class OCRService
    {
        private readonly string tessdataPath;

        private static readonly string[] PossiblePaths = new[]
        {
            @"C:\Program Files\Tesseract-OCR\tessdata",
            @"C:\Program Files (x86)\Tesseract-OCR\tessdata"
        };

        public OCRService()
        {
            tessdataPath = PossiblePaths.FirstOrDefault(Directory.Exists)
                ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");
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
                    engine.SetVariable("tessedit_char_whitelist",
                        "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz .,!?;:()[]{}\"'-_/@#$%&*+=<>|\\~`");

                    using (var img = Pix.LoadFromFile(imagePath))
                    using (var page = engine.Process(img))
                    {
                        return page.GetText()?.Trim() ?? string.Empty;
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

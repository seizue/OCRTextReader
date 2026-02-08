using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;

namespace OCRTextReader
{
    public class DocumentTextExtractorService
    {
        // Static constructor to set EPPlus license once for the entire application
        static DocumentTextExtractorService()
        {
            // Set EPPlus license for non-commercial personal use (EPPlus 8+)
            // Replace "Your Name" with your actual name or organization name
            OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("OCRTextReader User");
        }

        public async Task<string> ExtractTextAsync(string filePath)
        {
            return await Task.Run(() => ExtractText(filePath));
        }

        public string ExtractText(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();

            return extension switch
            {
                ".pdf" => ExtractTextFromPdf(filePath),
                ".xlsx" => ExtractTextFromExcel(filePath),
                ".xls" => throw new NotSupportedException("Legacy .xls format is not supported. Please convert to .xlsx format."),
                ".pptx" or ".ppt" => ExtractTextFromPowerPoint(filePath),
                _ => throw new NotSupportedException($"File type '{extension}' is not supported for text extraction.")
            };
        }

        private string ExtractTextFromPdf(string filePath)
        {
            try
            {
                StringBuilder text = new StringBuilder();

                using (PdfDocument pdfDoc = new PdfDocument(new PdfReader(filePath)))
                {
                    int numberOfPages = pdfDoc.GetNumberOfPages();

                    for (int pageNum = 1; pageNum <= numberOfPages; pageNum++)
                    {
                        PdfPage page = pdfDoc.GetPage(pageNum);
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        string pageText = PdfTextExtractor.GetTextFromPage(page, strategy);
                        
                        if (!string.IsNullOrWhiteSpace(pageText))
                        {
                            text.AppendLine(pageText);
                        }
                    }
                }

                return text.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to extract text from PDF: {ex.Message}", ex);
            }
        }

        private string ExtractTextFromExcel(string filePath)
        {
            try
            {
                StringBuilder text = new StringBuilder();

                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                    {
                        text.AppendLine($"--- Sheet: {worksheet.Name} ---");

                        int rowCount = worksheet.Dimension?.Rows ?? 0;
                        int colCount = worksheet.Dimension?.Columns ?? 0;

                        for (int row = 1; row <= rowCount; row++)
                        {
                            StringBuilder rowText = new StringBuilder();
                            bool hasData = false;

                            for (int col = 1; col <= colCount; col++)
                            {
                                var cell = worksheet.Cells[row, col];
                                if (cell.Value != null)
                                {
                                    string cellValue = cell.Value.ToString() ?? string.Empty;
                                    if (!string.IsNullOrWhiteSpace(cellValue))
                                    {
                                        rowText.Append(cellValue);
                                        hasData = true;
                                    }
                                }
                                if (col < colCount)
                                {
                                    rowText.Append("\t");
                                }
                            }

                            if (hasData)
                            {
                                text.AppendLine(rowText.ToString().TrimEnd());
                            }
                        }

                        text.AppendLine();
                    }
                }

                return text.ToString().Trim();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to extract text from Excel: {ex.Message}", ex);
            }
        }

        private string ExtractTextFromPowerPoint(string filePath)
        {
            try
            {
                string extension = Path.GetExtension(filePath).ToLowerInvariant();
                
                // OpenXML only supports .pptx format, not .ppt
                if (extension == ".ppt")
                {
                    throw new NotSupportedException("Legacy .ppt format is not supported. Please convert to .pptx format.");
                }

                StringBuilder text = new StringBuilder();

                using (PresentationDocument presentationDoc = PresentationDocument.Open(filePath, false))
                {
                    if (presentationDoc.PresentationPart == null)
                    {
                        return string.Empty;
                    }

                    var presentationPart = presentationDoc.PresentationPart;
                    var slideParts = presentationPart.SlideParts;

                    int slideNumber = 1;
                    foreach (var slidePart in slideParts)
                    {
                        text.AppendLine($"--- Slide {slideNumber} ---");

                        if (slidePart.Slide != null)
                        {
                            var slide = slidePart.Slide;
                            var textElements = slide.Descendants<DocumentFormat.OpenXml.Drawing.Text>();

                            foreach (var textElement in textElements)
                            {
                                string textContent = textElement.Text;
                                if (!string.IsNullOrWhiteSpace(textContent))
                                {
                                    text.AppendLine(textContent);
                                }
                            }
                        }

                        text.AppendLine();
                        slideNumber++;
                    }
                }

                return text.ToString().Trim();
            }
            catch (NotSupportedException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to extract text from PowerPoint: {ex.Message}", ex);
            }
        }
    }
}


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
        static DocumentTextExtractorService()
        {
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
                var text = new StringBuilder();

                using (var pdfDoc = new PdfDocument(new PdfReader(filePath)))
                {
                    int numberOfPages = pdfDoc.GetNumberOfPages();

                    for (int pageNum = 1; pageNum <= numberOfPages; pageNum++)
                    {
                        PdfPage page = pdfDoc.GetPage(pageNum);
                        string pageText = PdfTextExtractor.GetTextFromPage(page, new SimpleTextExtractionStrategy());

                        if (!string.IsNullOrWhiteSpace(pageText))
                            text.AppendLine(pageText);
                    }
                }

                return text.ToString().Trim();
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException($"Failed to extract text from PDF: {ex.Message}", ex);
            }
            catch (iText.Kernel.Exceptions.PdfException ex)
            {
                throw new InvalidOperationException($"Failed to extract text from PDF: {ex.Message}", ex);
            }
        }

        private string ExtractTextFromExcel(string filePath)
        {
            try
            {
                var text = new StringBuilder();
                var rowText = new StringBuilder();

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    foreach (ExcelWorksheet worksheet in package.Workbook.Worksheets)
                    {
                        text.AppendLine($"--- Sheet: {worksheet.Name} ---");

                        int rowCount = worksheet.Dimension?.Rows ?? 0;
                        int colCount = worksheet.Dimension?.Columns ?? 0;

                        for (int row = 1; row <= rowCount; row++)
                        {
                            rowText.Clear();
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
                                    rowText.Append('\t');
                            }

                            if (hasData)
                                text.AppendLine(rowText.ToString().TrimEnd());
                        }

                        text.AppendLine();
                    }
                }

                return text.ToString().Trim();
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException($"Failed to extract text from Excel: {ex.Message}", ex);
            }
            catch (InvalidDataException ex)
            {
                throw new InvalidOperationException($"Failed to extract text from Excel: {ex.Message}", ex);
            }
        }

        private string ExtractTextFromPowerPoint(string filePath)
        {
            try
            {
                if (Path.GetExtension(filePath).ToLowerInvariant() == ".ppt")
                    throw new NotSupportedException("Legacy .ppt format is not supported. Please convert to .pptx format.");

                var text = new StringBuilder();

                using (var presentationDoc = PresentationDocument.Open(filePath, false))
                {
                    if (presentationDoc.PresentationPart == null)
                        return string.Empty;

                    int slideNumber = 1;
                    foreach (var slidePart in presentationDoc.PresentationPart.SlideParts)
                    {
                        text.AppendLine($"--- Slide {slideNumber} ---");

                        if (slidePart.Slide != null)
                        {
                            var textElements = slidePart.Slide
                                .Descendants<DocumentFormat.OpenXml.Drawing.Text>()
                                .Select(t => t.Text)
                                .Where(t => !string.IsNullOrWhiteSpace(t));

                            foreach (var textContent in textElements)
                                text.AppendLine(textContent);
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
            catch (IOException ex)
            {
                throw new InvalidOperationException($"Failed to extract text from PowerPoint: {ex.Message}", ex);
            }
            catch (InvalidDataException ex)
            {
                throw new InvalidOperationException($"Failed to extract text from PowerPoint: {ex.Message}", ex);
            }
        }
    }
}

using System;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OCRTextReader
{
    public class WordExportService
    {
        public void ExportToWord(string text, string filePath, string sourceImageName = "")
        {
            try
            {
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    if (!string.IsNullOrEmpty(sourceImageName))
                    {
                        Paragraph titlePara = body.AppendChild(new Paragraph());
                        Run titleRun = titlePara.AppendChild(new Run());
                        titleRun.AppendChild(new Text($"Text Extracted from: {sourceImageName}"));
                        titleRun.RunProperties = new RunProperties
                        {
                            Bold = new Bold(),
                            FontSize = new FontSize { Val = "28" }
                        };
                        titlePara.ParagraphProperties = new ParagraphProperties
                        {
                            SpacingBetweenLines = new SpacingBetweenLines { After = "200" }
                        };
                    }

                    Paragraph datePara = body.AppendChild(new Paragraph());
                    Run dateRun = datePara.AppendChild(new Run());
                    dateRun.AppendChild(new Text($"Extracted on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}"));
                    dateRun.RunProperties = new RunProperties
                    {
                        Italic = new Italic(),
                        FontSize = new FontSize { Val = "20" },
                        Color = new DocumentFormat.OpenXml.Wordprocessing.Color { Val = "666666" }
                    };
                    datePara.ParagraphProperties = new ParagraphProperties
                    {
                        SpacingBetweenLines = new SpacingBetweenLines { After = "400" }
                    };

                    Paragraph separatorPara = body.AppendChild(new Paragraph());
                    separatorPara.ParagraphProperties = new ParagraphProperties
                    {
                        ParagraphBorders = new ParagraphBorders
                        {
                            BottomBorder = new BottomBorder
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Single),
                                Size = 12,
                                Space = 1
                            }
                        }
                    };

                    string[] lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                    foreach (string line in lines)
                    {
                        Paragraph para = body.AppendChild(new Paragraph());
                        Run run = para.AppendChild(new Run());
                        run.AppendChild(new Text(line));
                        run.RunProperties = new RunProperties
                        {
                            FontSize = new FontSize { Val = "22" }
                        };
                        para.ParagraphProperties = new ParagraphProperties
                        {
                            SpacingBetweenLines = new SpacingBetweenLines
                            {
                                Line = "360",
                                LineRule = LineSpacingRuleValues.Auto
                            }
                        };
                    }

                    mainPart.Document.Save();
                }
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException($"Failed to create Word document: {ex.Message}", ex);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException($"Failed to create Word document: {ex.Message}", ex);
            }
        }
    }
}

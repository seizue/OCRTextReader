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
                // Create a Word document
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    // Add main document part
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Add title
                    if (!string.IsNullOrEmpty(sourceImageName))
                    {
                        Paragraph titlePara = body.AppendChild(new Paragraph());
                        Run titleRun = titlePara.AppendChild(new Run());
                        titleRun.AppendChild(new Text($"Text Extracted from: {sourceImageName}"));
                        
                        RunProperties titleProps = new RunProperties();
                        titleProps.Bold = new Bold();
                        titleProps.FontSize = new FontSize() { Val = "28" };
                        titleRun.RunProperties = titleProps;

                        ParagraphProperties titleParaProps = new ParagraphProperties();
                        titleParaProps.SpacingBetweenLines = new SpacingBetweenLines() 
                        { 
                            After = "200" 
                        };
                        titlePara.ParagraphProperties = titleParaProps;
                    }

                    // Add date/time
                    Paragraph datePara = body.AppendChild(new Paragraph());
                    Run dateRun = datePara.AppendChild(new Run());
                    dateRun.AppendChild(new Text($"Extracted on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}"));
                    
                    RunProperties dateProps = new RunProperties();
                    dateProps.Italic = new Italic();
                    dateProps.FontSize = new FontSize() { Val = "20" };
                    dateProps.Color = new DocumentFormat.OpenXml.Wordprocessing.Color() { Val = "666666" };
                    dateRun.RunProperties = dateProps;

                    ParagraphProperties dateParaProps = new ParagraphProperties();
                    dateParaProps.SpacingBetweenLines = new SpacingBetweenLines() 
                    { 
                        After = "400" 
                    };
                    datePara.ParagraphProperties = dateParaProps;

                    // Add separator line
                    Paragraph separatorPara = body.AppendChild(new Paragraph());
                    ParagraphProperties separatorProps = new ParagraphProperties();
                    ParagraphBorders borders = new ParagraphBorders
                    {
                        BottomBorder = new BottomBorder
                        {
                            Val = new EnumValue<BorderValues>(BorderValues.Single),
                            Size = 12,
                            Space = 1
                        }
                    };
                    separatorProps.AppendChild(borders);
                    separatorPara.ParagraphProperties = separatorProps;

                    // Add extracted text
                    string[] lines = text.Split(new[] { "\r\n", "\r", "\n" }, 
                        StringSplitOptions.None);

                    foreach (string line in lines)
                    {
                        Paragraph para = body.AppendChild(new Paragraph());
                        Run run = para.AppendChild(new Run());
                        run.AppendChild(new Text(line));
                        
                        RunProperties runProps = new RunProperties();
                        runProps.FontSize = new FontSize() { Val = "22" };
                        run.RunProperties = runProps;

                        ParagraphProperties paraProps = new ParagraphProperties();
                        paraProps.SpacingBetweenLines = new SpacingBetweenLines() 
                        { 
                            Line = "360",
                            LineRule = LineSpacingRuleValues.Auto
                        };
                        para.ParagraphProperties = paraProps;
                    }

                    // Save the document
                    mainPart.Document.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create Word document: {ex.Message}", ex);
            }
        }
    }
}


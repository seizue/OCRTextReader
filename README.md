# OCRTextReader
A lightweight Windows desktop application that extracts text from images, PDFs, and Office documents with ease.

## Features
- **Image Selection**: Select images or documents (JPG, PNG, BMP, GIF, TIFF, PDF, EXCEL, POWERPOINT (PPTX)
- **OCR Processing**: Extract text from images using Tesseract OCR engine
- **Text Preview**: View extracted text in the application
- **Word Export**: Export extracted text to Microsoft Word (.docx) format
- **User-Friendly Interface**: Clean and intuitive Windows Forms UI built using the ReaLTaiizor UI framework.
  
## Download
[Download Link](https://github.com/seizue/OCRTextReader/releases/download/1.0.0/OCRTextReader_1.0.0.rar)

## Prerequisites
1. **.NET 4.8 SDK** or later
2. **Tesseract OCR** installed on your system

### Installing Tesseract OCR
#### Option 1: Using Installer (Recommended for Windows)
1. Download Tesseract OCR installer from: https://github.com/UB-Mannheim/tesseract/wiki
2. Run the installer and install to default location (usually `C:\Program Files\Tesseract-OCR`)
3. The installer includes English language data files by default

#### Option 2: Using Chocolatey
```powershell
choco install tesseract
```

#### Option 3: Manual Installation
1. Download Tesseract binaries
2. Extract to a folder (e.g., `C:\Tesseract-OCR`)
3. Download language data files from: https://github.com/tesseract-ocr/tessdata
4. Place `eng.traineddata` in the `tessdata` folder

## Building the Application
1. Open a terminal in the project directory
2. Restore NuGet packages:
   ```powershell
   dotnet restore
   ```
3. Build the project:
   ```powershell
   dotnet build
   ```
4. Run the application:
   ```powershell
   dotnet run
   ```

## Usage
1. **Launch the application**
2. **Click "Select Image/Document"** to choose an image file
3. **Click "Extract Text (OCR)"** to process the image and extract text
4. **Review the extracted text** in the text box
5. **Click "Export to Word Document"** to save the text as a .docx file

## Project Structure
```
OCRTextReaderApp/
├── MainForm.cs          # Main UI form
├── OCRService.cs        # OCR text extraction service
├── WordExportService.cs # Word document export service
├── Program.cs           # Application entry point
├── OCRTextReader.csproj # Project file
```

## Dependencies
- **Tesseract**: OCR engine for text extraction
- **DocumentFormat.OpenXml**: For creating Word documents

## Troubleshooting
### "OCR processing failed" Error
- Ensure Tesseract OCR is installed
- Verify that `eng.traineddata` exists in the tessdata folder
- Check that the tessdata path is accessible

### "No text could be extracted"
- The image quality might be too low
- Try using higher resolution images
- Ensure the image contains clear, readable text
- Check if the text is in a supported language (English by default)

## Notes
- The application currently supports English text extraction by default
- To add support for other languages, download the corresponding language data files from the Tesseract tessdata repository
- PDF files may require additional processing depending on their format

## Third-Party Libraries
This project uses the following open-source libraries:

- **Tesseract OCR** – Licensed under the Apache License 2.0  
  https://github.com/tesseract-ocr/tesseract

- **DocumentFormat.OpenXml** – Licensed under the MIT License  
  https://github.com/OfficeDev/Open-XML-SDK

- **ReaLTaiizor** – Licensed under the MIT License  
  https://github.com/Taiizor/ReaLTaiizor

## Screenshot
<img width="1366" height="718" alt="explorer_nYHulevtkv" src="https://github.com/user-attachments/assets/a38e89f1-4ee7-4221-bbb7-4af9e4b71aa5" />

## Icons by <a target="_blank" href="https://icons8.com">Icons8</a>

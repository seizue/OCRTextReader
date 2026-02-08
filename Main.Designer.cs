using System.Drawing;
using System.Windows.Forms;

namespace OCRTextReader
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.btnSelectDocOrImage = new System.Windows.Forms.Button();
            this.txtExtractedText = new System.Windows.Forms.RichTextBox();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.btnExportToWord = new ReaLTaiizor.Controls.HopeButton();
            this.btnProcessOCR = new ReaLTaiizor.Controls.HopeButton();
            this.lblStatus = new ReaLTaiizor.Controls.HopeTextBox();
            this.pictureBox = new ReaLTaiizor.Controls.HopePictureBox();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.txtExtractedTextBackground = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblImagePath = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.nightForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.nightForm1.Controls.Add(this.btnSelectDocOrImage);
            this.nightForm1.Controls.Add(this.txtExtractedText);
            this.nightForm1.Controls.Add(this.btnGitHub);
            this.nightForm1.Controls.Add(this.btnExportToWord);
            this.nightForm1.Controls.Add(this.btnProcessOCR);
            this.nightForm1.Controls.Add(this.lblStatus);
            this.nightForm1.Controls.Add(this.pictureBox);
            this.nightForm1.Controls.Add(this.btnClearSelection);
            this.nightForm1.Controls.Add(this.txtExtractedTextBackground);
            this.nightForm1.Controls.Add(this.lblImagePath);
            this.nightForm1.Controls.Add(this.panel1);
            this.nightForm1.Controls.Add(this.hopePictureBox1);
            this.nightForm1.Controls.Add(this.parrotGradientPanel1);
            this.nightForm1.Controls.Add(this.btnMinimize);
            this.nightForm1.Controls.Add(this.btnClose);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = false;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(86, 36);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 27, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(664, 491);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // btnSelectDocOrImage
            // 
            this.btnSelectDocOrImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnSelectDocOrImage.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSelectDocOrImage.FlatAppearance.BorderSize = 2;
            this.btnSelectDocOrImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDocOrImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelectDocOrImage.Location = new System.Drawing.Point(42, 87);
            this.btnSelectDocOrImage.Name = "btnSelectDocOrImage";
            this.btnSelectDocOrImage.Size = new System.Drawing.Size(116, 28);
            this.btnSelectDocOrImage.TabIndex = 18;
            this.btnSelectDocOrImage.Text = "SELECT FILE";
            this.btnSelectDocOrImage.UseVisualStyleBackColor = false;
            this.btnSelectDocOrImage.Click += new System.EventHandler(this.btnSelectDocOrImage_Click);
            // 
            // txtExtractedText
            // 
            this.txtExtractedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.txtExtractedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExtractedText.ForeColor = System.Drawing.Color.White;
            this.txtExtractedText.Location = new System.Drawing.Point(245, 136);
            this.txtExtractedText.Name = "txtExtractedText";
            this.txtExtractedText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtExtractedText.Size = new System.Drawing.Size(376, 294);
            this.txtExtractedText.TabIndex = 17;
            this.txtExtractedText.Text = "";
            // 
            // btnGitHub
            // 
            this.btnGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGitHub.BackColor = System.Drawing.Color.Transparent;
            this.btnGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGitHub.Image = ((System.Drawing.Image)(resources.GetObject("btnGitHub.Image")));
            this.btnGitHub.Location = new System.Drawing.Point(104, 434);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(31, 27);
            this.btnGitHub.TabIndex = 14;
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnExportToWord
            // 
            this.btnExportToWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnExportToWord.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnExportToWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportToWord.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnExportToWord.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExportToWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToWord.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnExportToWord.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnExportToWord.Location = new System.Drawing.Point(39, 393);
            this.btnExportToWord.Name = "btnExportToWord";
            this.btnExportToWord.PrimaryColor = System.Drawing.Color.DodgerBlue;
            this.btnExportToWord.Size = new System.Drawing.Size(171, 29);
            this.btnExportToWord.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnExportToWord.TabIndex = 7;
            this.btnExportToWord.Text = "EXPORT TO WORD";
            this.btnExportToWord.TextColor = System.Drawing.Color.White;
            this.btnExportToWord.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnExportToWord.Click += new System.EventHandler(this.btnExportToWord_Click);
            // 
            // btnProcessOCR
            // 
            this.btnProcessOCR.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnProcessOCR.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnProcessOCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessOCR.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnProcessOCR.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProcessOCR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessOCR.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnProcessOCR.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnProcessOCR.Location = new System.Drawing.Point(39, 351);
            this.btnProcessOCR.Name = "btnProcessOCR";
            this.btnProcessOCR.PrimaryColor = System.Drawing.Color.IndianRed;
            this.btnProcessOCR.Size = new System.Drawing.Size(171, 29);
            this.btnProcessOCR.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnProcessOCR.TabIndex = 16;
            this.btnProcessOCR.Text = "EXTRACT TEXT";
            this.btnProcessOCR.TextColor = System.Drawing.Color.White;
            this.btnProcessOCR.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnProcessOCR.Click += new System.EventHandler(this.btnProcessOCR_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.lblStatus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.lblStatus.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.lblStatus.BorderColorB = System.Drawing.Color.Gray;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStatus.Hint = "";
            this.lblStatus.Location = new System.Drawing.Point(45, 278);
            this.lblStatus.MaxLength = 32767;
            this.lblStatus.Multiline = true;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.PasswordChar = '\0';
            this.lblStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblStatus.SelectedText = "";
            this.lblStatus.SelectionLength = 0;
            this.lblStatus.SelectionStart = 0;
            this.lblStatus.Size = new System.Drawing.Size(161, 56);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.TabStop = false;
            this.lblStatus.UseSystemPasswordChar = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.pictureBox.BackgroundImage = global::OCRTextReader.Properties.Resources.image_document_240px;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Image = global::OCRTextReader.Properties.Resources.image_document_240px;
            this.pictureBox.Location = new System.Drawing.Point(45, 138);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pictureBox.Size = new System.Drawing.Size(161, 119);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            this.pictureBox.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSelection.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSelection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnClearSelection.FlatAppearance.BorderSize = 0;
            this.btnClearSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClearSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearSelection.Image = global::OCRTextReader.Properties.Resources.broom_24px;
            this.btnClearSelection.Location = new System.Drawing.Point(189, 88);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(31, 27);
            this.btnClearSelection.TabIndex = 13;
            this.btnClearSelection.UseVisualStyleBackColor = false;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // txtExtractedTextBackground
            // 
            this.txtExtractedTextBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.txtExtractedTextBackground.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtExtractedTextBackground.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtExtractedTextBackground.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtExtractedTextBackground.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.txtExtractedTextBackground.ForeColor = System.Drawing.Color.White;
            this.txtExtractedTextBackground.Hint = "";
            this.txtExtractedTextBackground.Location = new System.Drawing.Point(242, 133);
            this.txtExtractedTextBackground.MaxLength = 32767;
            this.txtExtractedTextBackground.Multiline = true;
            this.txtExtractedTextBackground.Name = "txtExtractedTextBackground";
            this.txtExtractedTextBackground.PasswordChar = '\0';
            this.txtExtractedTextBackground.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExtractedTextBackground.SelectedText = "";
            this.txtExtractedTextBackground.SelectionLength = 0;
            this.txtExtractedTextBackground.SelectionStart = 0;
            this.txtExtractedTextBackground.Size = new System.Drawing.Size(383, 301);
            this.txtExtractedTextBackground.TabIndex = 11;
            this.txtExtractedTextBackground.TabStop = false;
            this.txtExtractedTextBackground.UseSystemPasswordChar = false;
            // 
            // lblImagePath
            // 
            this.lblImagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.lblImagePath.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.lblImagePath.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.lblImagePath.BorderColorB = System.Drawing.Color.Gray;
            this.lblImagePath.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.lblImagePath.ForeColor = System.Drawing.Color.LightGray;
            this.lblImagePath.Hint = "";
            this.lblImagePath.Location = new System.Drawing.Point(242, 87);
            this.lblImagePath.MaxLength = 32767;
            this.lblImagePath.Multiline = false;
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.PasswordChar = '\0';
            this.lblImagePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblImagePath.SelectedText = "";
            this.lblImagePath.SelectionLength = 0;
            this.lblImagePath.SelectionStart = 0;
            this.lblImagePath.Size = new System.Drawing.Size(383, 32);
            this.lblImagePath.TabIndex = 10;
            this.lblImagePath.TabStop = false;
            this.lblImagePath.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 38);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(156, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Extract Text from Images and Documents";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "OCRTextReader";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 1);
            this.panel2.TabIndex = 9;
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.hopePictureBox1.Location = new System.Drawing.Point(39, 133);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(171, 129);
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 5;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 483);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(664, 9);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 3;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.Lime;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.Red;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.Image = global::OCRTextReader.Properties.Resources.minus_20px;
            this.btnMinimize.Location = new System.Drawing.Point(596, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 27);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(633, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
            this.openFileDialog.Title = "Select Image or Document";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "docx";
            this.saveFileDialog.Filter = "Word Documents|*.docx|All Files|*.*";
            this.saveFileDialog.Title = "Save Extracted Text as Word Document";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 491);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1171, 624);
            this.MinimumSize = new System.Drawing.Size(163, 35);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private Button btnMinimize;
        private Button btnClose;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.HopeButton btnExportToWord;
        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.HopeTextBox lblImagePath;
        private ReaLTaiizor.Controls.HopeTextBox txtExtractedTextBackground;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.HopePictureBox pictureBox;
        private Button btnClearSelection;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox lblStatus;
        private ReaLTaiizor.Controls.HopeButton btnProcessOCR;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button btnGitHub;
        private RichTextBox txtExtractedText;
        private Button btnSelectDocOrImage;
    }
}
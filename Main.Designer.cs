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
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            btnSelectDocOrImage = new Button();
            txtExtractedText = new RichTextBox();
            btnGitHub = new Button();
            btnExportToWord = new ReaLTaiizor.Controls.HopeButton();
            btnProcessOCR = new ReaLTaiizor.Controls.HopeButton();
            lblStatus = new ReaLTaiizor.Controls.HopeTextBox();
            pictureBox = new ReaLTaiizor.Controls.HopePictureBox();
            btnClearSelection = new Button();
            txtExtractedTextBackground = new ReaLTaiizor.Controls.HopeTextBox();
            lblImagePath = new ReaLTaiizor.Controls.HopeTextBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            btnMinimize = new Button();
            btnClose = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            nightForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(btnSelectDocOrImage);
            nightForm1.Controls.Add(txtExtractedText);
            nightForm1.Controls.Add(btnGitHub);
            nightForm1.Controls.Add(btnExportToWord);
            nightForm1.Controls.Add(btnProcessOCR);
            nightForm1.Controls.Add(lblStatus);
            nightForm1.Controls.Add(pictureBox);
            nightForm1.Controls.Add(btnClearSelection);
            nightForm1.Controls.Add(txtExtractedTextBackground);
            nightForm1.Controls.Add(lblImagePath);
            nightForm1.Controls.Add(panel1);
            nightForm1.Controls.Add(hopePictureBox1);
            nightForm1.Controls.Add(parrotGradientPanel1);
            nightForm1.Controls.Add(btnMinimize);
            nightForm1.Controls.Add(btnClose);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(775, 567);
            nightForm1.TabIndex = 0;
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // btnSelectDocOrImage
            // 
            btnSelectDocOrImage.BackColor = Color.FromArgb(50, 58, 61);
            btnSelectDocOrImage.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            btnSelectDocOrImage.FlatAppearance.BorderSize = 2;
            btnSelectDocOrImage.FlatStyle = FlatStyle.Flat;
            btnSelectDocOrImage.ForeColor = Color.FromArgb(224, 224, 224);
            btnSelectDocOrImage.Location = new Point(49, 100);
            btnSelectDocOrImage.Name = "btnSelectDocOrImage";
            btnSelectDocOrImage.Size = new Size(135, 32);
            btnSelectDocOrImage.TabIndex = 18;
            btnSelectDocOrImage.Text = "SELECT FILE";
            btnSelectDocOrImage.UseVisualStyleBackColor = false;
            btnSelectDocOrImage.Click += btnSelectDocOrImage_Click;
            // 
            // txtExtractedText
            // 
            txtExtractedText.BackColor = Color.FromArgb(50, 58, 61);
            txtExtractedText.BorderStyle = BorderStyle.None;
            txtExtractedText.ForeColor = Color.White;
            txtExtractedText.Location = new Point(286, 157);
            txtExtractedText.Name = "txtExtractedText";
            txtExtractedText.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtExtractedText.Size = new Size(439, 339);
            txtExtractedText.TabIndex = 17;
            txtExtractedText.Text = "";
            // 
            // btnGitHub
            // 
            btnGitHub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGitHub.BackColor = Color.Transparent;
            btnGitHub.FlatAppearance.BorderColor = Color.FromArgb(50, 58, 61);
            btnGitHub.FlatAppearance.BorderSize = 0;
            btnGitHub.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnGitHub.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnGitHub.FlatStyle = FlatStyle.Flat;
            btnGitHub.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnGitHub.ForeColor = Color.FromArgb(224, 224, 224);
            btnGitHub.Image = (Image)resources.GetObject("btnGitHub.Image");
            btnGitHub.Location = new Point(121, 501);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(36, 31);
            btnGitHub.TabIndex = 14;
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // btnExportToWord
            // 
            btnExportToWord.BorderColor = Color.FromArgb(220, 223, 230);
            btnExportToWord.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnExportToWord.DangerColor = Color.FromArgb(245, 108, 108);
            btnExportToWord.DefaultColor = Color.FromArgb(255, 255, 255);
            btnExportToWord.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportToWord.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnExportToWord.InfoColor = Color.FromArgb(144, 147, 153);
            btnExportToWord.Location = new Point(46, 453);
            btnExportToWord.Name = "btnExportToWord";
            btnExportToWord.PrimaryColor = Color.DodgerBlue;
            btnExportToWord.Size = new Size(200, 33);
            btnExportToWord.SuccessColor = Color.FromArgb(103, 194, 58);
            btnExportToWord.TabIndex = 7;
            btnExportToWord.Text = "EXPORT TO WORD";
            btnExportToWord.TextColor = Color.White;
            btnExportToWord.WarningColor = Color.FromArgb(230, 162, 60);
            btnExportToWord.Click += btnExportToWord_Click;
            // 
            // btnProcessOCR
            // 
            btnProcessOCR.BorderColor = Color.FromArgb(220, 223, 230);
            btnProcessOCR.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnProcessOCR.DangerColor = Color.FromArgb(245, 108, 108);
            btnProcessOCR.DefaultColor = Color.FromArgb(255, 255, 255);
            btnProcessOCR.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessOCR.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnProcessOCR.InfoColor = Color.FromArgb(144, 147, 153);
            btnProcessOCR.Location = new Point(46, 405);
            btnProcessOCR.Name = "btnProcessOCR";
            btnProcessOCR.PrimaryColor = Color.IndianRed;
            btnProcessOCR.Size = new Size(200, 33);
            btnProcessOCR.SuccessColor = Color.FromArgb(103, 194, 58);
            btnProcessOCR.TabIndex = 16;
            btnProcessOCR.Text = "EXTRACT TEXT";
            btnProcessOCR.TextColor = Color.White;
            btnProcessOCR.WarningColor = Color.FromArgb(230, 162, 60);
            btnProcessOCR.Click += btnProcessOCR_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.FromArgb(50, 58, 61);
            lblStatus.BaseColor = Color.FromArgb(44, 55, 66);
            lblStatus.BorderColorA = Color.FromArgb(64, 158, 255);
            lblStatus.BorderColorB = Color.Gray;
            lblStatus.Font = new Font("Calibri", 9.25F);
            lblStatus.ForeColor = Color.FromArgb(192, 255, 192);
            lblStatus.Hint = "";
            lblStatus.Location = new Point(52, 321);
            lblStatus.MaxLength = 32767;
            lblStatus.Multiline = true;
            lblStatus.Name = "lblStatus";
            lblStatus.PasswordChar = '\0';
            lblStatus.ScrollBars = ScrollBars.None;
            lblStatus.SelectedText = "";
            lblStatus.SelectionLength = 0;
            lblStatus.SelectionStart = 0;
            lblStatus.Size = new Size(188, 65);
            lblStatus.TabIndex = 15;
            lblStatus.TabStop = false;
            lblStatus.UseSystemPasswordChar = false;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.FromArgb(50, 58, 61);
            pictureBox.BackgroundImage = Properties.Resources.image_document_240px;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Image = Properties.Resources.image_document_240px;
            pictureBox.Location = new Point(52, 159);
            pictureBox.Name = "pictureBox";
            pictureBox.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pictureBox.Size = new Size(188, 137);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pictureBox.TabIndex = 14;
            pictureBox.TabStop = false;
            pictureBox.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnClearSelection
            // 
            btnClearSelection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearSelection.BackColor = Color.Transparent;
            btnClearSelection.FlatAppearance.BorderColor = Color.FromArgb(50, 58, 61);
            btnClearSelection.FlatAppearance.BorderSize = 0;
            btnClearSelection.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnClearSelection.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClearSelection.FlatStyle = FlatStyle.Flat;
            btnClearSelection.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnClearSelection.ForeColor = Color.FromArgb(224, 224, 224);
            btnClearSelection.Image = Properties.Resources.broom_24px;
            btnClearSelection.Location = new Point(221, 101);
            btnClearSelection.Name = "btnClearSelection";
            btnClearSelection.Size = new Size(36, 31);
            btnClearSelection.TabIndex = 13;
            btnClearSelection.UseVisualStyleBackColor = false;
            btnClearSelection.Click += btnClearSelection_Click;
            // 
            // txtExtractedTextBackground
            // 
            txtExtractedTextBackground.BackColor = Color.FromArgb(50, 58, 61);
            txtExtractedTextBackground.BaseColor = Color.FromArgb(44, 55, 66);
            txtExtractedTextBackground.BorderColorA = Color.FromArgb(64, 158, 255);
            txtExtractedTextBackground.BorderColorB = Color.FromArgb(220, 223, 230);
            txtExtractedTextBackground.Font = new Font("Calibri", 9.25F);
            txtExtractedTextBackground.ForeColor = Color.White;
            txtExtractedTextBackground.Hint = "";
            txtExtractedTextBackground.Location = new Point(282, 153);
            txtExtractedTextBackground.MaxLength = 32767;
            txtExtractedTextBackground.Multiline = true;
            txtExtractedTextBackground.Name = "txtExtractedTextBackground";
            txtExtractedTextBackground.PasswordChar = '\0';
            txtExtractedTextBackground.ScrollBars = ScrollBars.None;
            txtExtractedTextBackground.SelectedText = "";
            txtExtractedTextBackground.SelectionLength = 0;
            txtExtractedTextBackground.SelectionStart = 0;
            txtExtractedTextBackground.Size = new Size(447, 347);
            txtExtractedTextBackground.TabIndex = 11;
            txtExtractedTextBackground.TabStop = false;
            txtExtractedTextBackground.UseSystemPasswordChar = false;
            // 
            // lblImagePath
            // 
            lblImagePath.BackColor = Color.FromArgb(50, 58, 61);
            lblImagePath.BaseColor = Color.FromArgb(44, 55, 66);
            lblImagePath.BorderColorA = Color.FromArgb(64, 158, 255);
            lblImagePath.BorderColorB = Color.Gray;
            lblImagePath.Font = new Font("Calibri", 9.25F);
            lblImagePath.ForeColor = Color.LightGray;
            lblImagePath.Hint = "";
            lblImagePath.Location = new Point(282, 100);
            lblImagePath.MaxLength = 32767;
            lblImagePath.Multiline = false;
            lblImagePath.Name = "lblImagePath";
            lblImagePath.PasswordChar = '\0';
            lblImagePath.ScrollBars = ScrollBars.None;
            lblImagePath.SelectedText = "";
            lblImagePath.SelectionLength = 0;
            lblImagePath.SelectionStart = 0;
            lblImagePath.Size = new Size(447, 32);
            lblImagePath.TabIndex = 10;
            lblImagePath.TabStop = false;
            lblImagePath.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 44);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(182, 14);
            label2.Name = "label2";
            label2.Size = new Size(227, 15);
            label2.TabIndex = 11;
            label2.Text = "Extract Text from Images and Documents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(47, 13);
            label1.Name = "label1";
            label1.Size = new Size(135, 17);
            label1.TabIndex = 10;
            label1.Text = "OCRTextReader";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 43, 46);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 1);
            panel2.TabIndex = 9;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(50, 58, 61);
            hopePictureBox1.Location = new Point(46, 153);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(200, 149);
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 5;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            parrotGradientPanel1.BottomLeft = Color.FromArgb(64, 64, 64);
            parrotGradientPanel1.BottomRight = Color.FromArgb(64, 64, 64);
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotGradientPanel1.Location = new Point(0, 557);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotGradientPanel1.PrimerColor = Color.White;
            parrotGradientPanel1.Size = new Size(775, 10);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 3;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotGradientPanel1.TopLeft = Color.Lime;
            parrotGradientPanel1.TopRight = Color.Red;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(50, 58, 61);
            btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(50, 58, 61);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 58, 61);
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 58, 61);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.FromArgb(224, 224, 224);
            btnMinimize.Image = Properties.Resources.minus_20px;
            btnMinimize.Location = new Point(695, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(36, 31);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(50, 58, 61);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(50, 58, 61);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(224, 224, 224);
            btnClose.Location = new Point(738, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 31);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
            openFileDialog.Title = "Select Image or Document";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "docx";
            saveFileDialog.Filter = "Word Documents|*.docx|All Files|*.*";
            saveFileDialog.Title = "Save Extracted Text as Word Document";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 567);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 720);
            MinimumSize = new Size(190, 40);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTheme1";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
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
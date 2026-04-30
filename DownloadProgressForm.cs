using System.Drawing;
using System.Windows.Forms;

namespace OCRTextReader
{
    public sealed class DownloadProgressForm : Form
    {
        private readonly ProgressBar progressBar;
        private readonly Label lblMessage;

        public DownloadProgressForm()
        {
            lblMessage = new Label
            {
                Text = "Preparing download...",
                Location = new Point(12, 12),
                Size = new Size(380, 20),
                AutoSize = false
            };

            progressBar = new ProgressBar
            {
                Location = new Point(12, 38),
                Size = new Size(380, 24),
                Minimum = 0,
                Maximum = 100,
                Value = 0,
                Style = ProgressBarStyle.Continuous
            };

            SuspendLayout();
            Text = "Installing Tesseract OCR";
            Size = new Size(420, 120);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Controls.Add(lblMessage);
            Controls.Add(progressBar);
            ResumeLayout(false);
        }

        public void UpdateProgress(int percent, string message)
        {
            if (progressBar.Value != percent)
                progressBar.Value = percent;

            if (lblMessage.Text != message)
                lblMessage.Text = message;
        }
    }
}

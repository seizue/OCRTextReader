using System.Drawing;
using System.Windows.Forms;

namespace OCRTextReader
{
    /// <summary>
    /// Simple progress dialog shown while downloading the Tesseract installer.
    /// </summary>
    public class DownloadProgressForm : Form
    {
        private ProgressBar progressBar;
        private Label lblMessage;

        public DownloadProgressForm()
        {
            Text = "Installing Tesseract OCR";
            Size = new Size(420, 120);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;

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

            Controls.Add(lblMessage);
            Controls.Add(progressBar);
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

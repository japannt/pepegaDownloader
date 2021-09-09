
namespace pepegaDownloader
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.smallTitle = new System.Windows.Forms.Label();
            this.centerText = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.processingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smallTitle
            // 
            this.smallTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.smallTitle.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.smallTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smallTitle.Location = new System.Drawing.Point(77, 10);
            this.smallTitle.Name = "smallTitle";
            this.smallTitle.Size = new System.Drawing.Size(158, 15);
            this.smallTitle.TabIndex = 0;
            this.smallTitle.Text = "Please sit back, and enjoy the";
            this.smallTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // centerText
            // 
            this.centerText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.centerText.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.centerText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.centerText.Location = new System.Drawing.Point(0, 27);
            this.centerText.Name = "centerText";
            this.centerText.Size = new System.Drawing.Size(324, 54);
            this.centerText.TabIndex = 0;
            this.centerText.Text = "the pepe downloadge.";
            this.centerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cancelButton.Location = new System.Drawing.Point(237, 115);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar1.Location = new System.Drawing.Point(12, 115);
            this.progressBar1.Maximum = 1854;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // processingLabel
            // 
            this.processingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processingLabel.AutoSize = true;
            this.processingLabel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.processingLabel.Location = new System.Drawing.Point(12, 87);
            this.processingLabel.Name = "processingLabel";
            this.processingLabel.Size = new System.Drawing.Size(128, 15);
            this.processingLabel.TabIndex = 3;
            this.processingLabel.Text = "Invoking Webrequest...";
            // 
            // mainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(324, 150);
            this.Controls.Add(this.processingLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.centerText);
            this.Controls.Add(this.smallTitle);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pepeDownloader";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label smallTitle;
        private System.Windows.Forms.Label centerText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label processingLabel;
    }
}
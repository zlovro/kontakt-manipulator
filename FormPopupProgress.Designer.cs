using System.ComponentModel;

namespace smanip
{
    partial class FormPopupProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.progressBar   = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 35);
            this.progressBar.Name     = "progressBar";
            this.progressBar.Size     = new System.Drawing.Size(328, 23);
            this.progressBar.Step     = 0;
            this.progressBar.TabIndex = 0;
            // 
            // labelProgress
            // 
            this.labelProgress.Location  = new System.Drawing.Point(12, 9);
            this.labelProgress.Name      = "labelProgress";
            this.labelProgress.Size      = new System.Drawing.Size(328, 23);
            this.labelProgress.TabIndex  = 1;
            this.labelProgress.Text      = "Progress";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPopupProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(355, 65);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar);
            this.Name = "FormPopupProgress";
            this.Text = "FormPopupProgress";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label       labelProgress;

        #endregion

    }
}
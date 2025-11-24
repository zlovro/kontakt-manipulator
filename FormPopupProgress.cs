using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace smanip
{
    public partial class FormPopupProgress : Form
    {
        public FormPopupProgress()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pProgress">0 - 1</param>
        public void Update(float pProgress, string pLabel)
        {
            progressBar.Value = (int)(pProgress * 1000);
            SetText(pLabel);
        }
        public void SetText(string pLabel)
        {
            progressBar.Text = pLabel;
        }

        public static FormPopupProgress Show()
        {
            var f = new FormPopupProgress();
            ((Control)f).Show();
            return f;
        }

        public static FormPopupProgress Show(BackgroundWorker pWorker)
        {
            var f = Show();
            pWorker.ProgressChanged += (pSender, pArgs) =>
            {
                f.labelProgress.Text = (string)pArgs.UserState;
                f.progressBar.Value  = pArgs.ProgressPercentage;
            };

            pWorker.RunWorkerCompleted += (pSender, pArgs) =>
            {
                f.Hide();
            };

            return f;
        }
    }
}
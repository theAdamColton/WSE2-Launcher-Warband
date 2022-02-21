using ConfigController;
using System;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    public partial class ConfigForm : Form
    {
        private RglSettings Settings;

        public ConfigForm(RglSettings settings)
        {
            Settings = settings;

            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            languageBox.Items.AddRange(new string[] { "Cesky", "English", "Deutsch", "Espanol", "Francais", "Magyar", "Polski", "Russkiy", "Turkce" });
            hideBloodBox.Checked = !Settings.bBlood;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            //support dragging the window
            if (m.Msg == ApiHelper.WM_NCHITTEST && (int)m.Result == ApiHelper.HTCLIENT)
            {
                m.Result = new IntPtr(ApiHelper.HTCAPTION);
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Cancel_Click(sender, e);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Settings.WriteSettings();
            closeButton_Click(sender, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hideBloodBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.bBlood = !hideBloodBox.Checked;
        }
    }
}

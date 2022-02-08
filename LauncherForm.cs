using System;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    public partial class LauncherForm : Form
    {
        //private PerPixelAlphaForm background;
        private FormBackground background;
        public LauncherForm()
        {
            InitializeComponent();

            //remove this form's background, because it causes weird graphics
            this.BackgroundImage = null;
            this.background = new FormBackground(Properties.Resources.background, this);
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
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void configureLabel_Click(object sender, EventArgs e)
        {
            ConfigForm cf = new ConfigForm();
            cf.Show();
        }
    }
}

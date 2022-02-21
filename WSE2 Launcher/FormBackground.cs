using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WSE2_Launcher
{
    /// <summary>
    /// Thanks to https://www.codeproject.com/Tips/1224958/Winforms-Transparent-Background-Image-with-Gradien
    /// for all of this code.
    /// 
    /// Use like:
    //public partial class FormSplash : Form
    //{
    //    private FormBackground _background;
    //    public FormSplash()
    //    {
    //        InitializeComponent();

    //        //remove this form's background, because it causes weird graphics
    //        this.BackgroundImage = null;
    //        _background = new FormBackground(Resources.Splash, this);
    //    }

    //    protected override void WndProc(ref Message m)
    //    {
    //        base.WndProc(ref m);
    //        //support dragging the window
    //        if (m.Msg == ApiHelper.WM_NCHITTEST && (int)m.Result == ApiHelper.HTCLIENT)
    //        {
    //            m.Result = new IntPtr(ApiHelper.HTCAPTION);
    //        }
    //    }

    //    private void button1_Click(object sender, EventArgs e)
    //    {
    //        Close();
    //    }
    //}
    /// </summary>
    class FormBackground : Form
    {
        private readonly Form _parent;
        private int _offsetx;
        private int _offsety;
        public FormBackground(Bitmap bitmap, Form parent, int offsetx = 0, int offsety = 0)
        {
            _parent = parent;
            this.TopMost = _parent.TopMost;
            if ((TopMost))
                _parent.TopMost = true;
            this.ShowInTaskbar = false;
            this.Size = bitmap.Size;
            this.SelectBitmap(bitmap);
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            _offsetx = offsetx;
            _offsety = offsety;
            _parent.Shown += Parent_Shown;
            _parent.FormClosing += Parent_FormClosing;
            _parent.Move += Parent_Move;
            _parent.Activated += Parent_Activated;
        }

        private void Parent_Shown(object sender, EventArgs e)
        {
            FixLocation();
            Show();
            _parent.BringToFront();
        }

        private void Parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void Parent_Move(object sender, EventArgs e)
        {
            Visible = (_parent.WindowState == FormWindowState.Normal);
            if (Visible)
            {
                FixLocation();
            }
        }

        private void FixLocation()
        {
            Point point = _parent.Location;
            point.Offset(_offsetx, _offsety);
            this.Location = point;
        }

        private void Parent_Activated(object sender, EventArgs e)
        {
            var reorder = ApiHelper.GetWindow(_parent.Handle, ApiHelper.GetWindow_Cmd.GW_HWNDNEXT) != this.Handle;
            if (reorder)
            {
                BringToFront();
                _parent.BringToFront();
            }
        }

        public void SelectBitmap(Bitmap bitmap)
        {
            if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
            {
                throw new ApplicationException("The bitmap must be 32bpp with alpha-channel.");
            }

            IntPtr screenDc = ApiHelper.GetDC(IntPtr.Zero);
            IntPtr memDc = ApiHelper.CreateCompatibleDC(screenDc);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr hOldBitmap = IntPtr.Zero;
            try
            {
                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                hOldBitmap = ApiHelper.SelectObject(memDc, hBitmap);
                ApiHelper.ApiSize newApiSize = new ApiHelper.ApiSize(bitmap.Width, bitmap.Height);
                ApiHelper.ApiPoint sourceLocation = new ApiHelper.ApiPoint(0, 0);
                ApiHelper.ApiPoint newLocation = new ApiHelper.ApiPoint(this.Left, this.Top);
                ApiHelper.BLENDFUNCTION blend = new ApiHelper.BLENDFUNCTION();
                blend.BlendOp = ApiHelper.AC_SRC_OVER;
                blend.BlendFlags = 0;
                blend.SourceConstantAlpha = 255;
                blend.AlphaFormat = ApiHelper.AC_SRC_ALPHA;
                //inject the alpha image in this Form's graphic layer
                ApiHelper.UpdateLayeredWindow(Handle, screenDc, ref newLocation, ref newApiSize, memDc, ref sourceLocation, 0, ref blend, ApiHelper.ULW_ALPHA);
            }
            finally
            {
                ApiHelper.ReleaseDC(IntPtr.Zero, screenDc);
                if (hBitmap != IntPtr.Zero)
                {
                    ApiHelper.SelectObject(memDc, hOldBitmap);
                    ApiHelper.DeleteObject(hBitmap);
                }

                ApiHelper.DeleteDC(memDc);
            }
        }

        //mark this Form to be rendered using multiple layers
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ExStyle = p.ExStyle | ApiHelper.WS_EX_LAYERED;
                return p;
            }
        }

    }
}


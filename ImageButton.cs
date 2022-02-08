using System.Windows.Forms;

namespace WSE2_Launcher
{
    class ImageButton : Button
    {
        public ImageButton()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.Text = null;
            this.BackgroundImage = Properties.Resources.closebutton;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TabIndex = 0;
            this.TabStop = false;
            this.UseVisualStyleBackColor = false;
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Petshop
{
    public class OvalPictureBox:PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.Transparent;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, 50 , 50));
                this.Region = new Region(gp);
            }
        }

    }
}

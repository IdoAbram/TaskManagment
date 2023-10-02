using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagment.design
{
    internal class RoundedButton : Button
    {
        private int cornerRadius = 10; // Adjust this value to change the corner radius

        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                int diameter = cornerRadius * 2;

                graphicsPath.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
                graphicsPath.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
                graphicsPath.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                graphicsPath.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                graphicsPath.CloseFigure();

                Region = new Region(graphicsPath);
            }
        }
    }

}

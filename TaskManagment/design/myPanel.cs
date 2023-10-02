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
    internal class RoundedPanel : Panel
    {
        private int cornerRadius = 30; // Adjust this value to change the corner radius

        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var graphicsPath = new GraphicsPath())
            {
                var bounds = new Rectangle(0, 0, Width, Height);
                int diameter = cornerRadius * 2;

                graphicsPath.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
                graphicsPath.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
                graphicsPath.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                graphicsPath.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                graphicsPath.CloseFigure();

                Region = new Region(graphicsPath);
                using (var pen = new Pen(BackColor, 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, graphicsPath);
                    e.Graphics.FillPath(new SolidBrush(BackColor), graphicsPath);
                }
            }
        }
    }

}

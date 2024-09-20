using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Quizzz
{
    public static class ControlExtensions
    {
        public static void SetRoundedCorners(this Control control, int radius)
        {
            if (radius <= 0)
                return;

            GraphicsPath path = new GraphicsPath();
            RectangleF bounds = new RectangleF(0, 0, control.Width, control.Height);

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            Region region = new Region(path);
            control.Region = region;
        }
    }
}

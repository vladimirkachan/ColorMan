using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColorMan.AppForms
{
    public partial class ColorBoxView : View
    {
        const int stroke = 3;
        protected Size Downed { get; set; }
        protected Size Previous { get; set; }
        protected GraphicsPath GraphicalPath { get; set; }
        public AppSpace AppSpace { get; set; }
        
        public ColorBoxView()
        {
            InitializeComponent();
        }

        protected override void CmsViewOpening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
        protected void SetCursor(Point loc)
        {
            bool top = NearTop(loc), right = NearRight(loc), bottom = NearBottom(loc), left = NearLeft(loc);
            Cursor = top && left || bottom && right
                ? Cursors.SizeNWSE
                : top && right || bottom && left
                    ? Cursors.SizeNESW
                    : top || bottom ? Cursors.SizeNS : left || right ? Cursors.SizeWE : Cursors.Default;
        }
        static bool NearTop(Point loc)
        {
            return loc.Y >= 0 && loc.Y <= stroke;
        }
        bool NearRight(Point loc)
        {
            float width = GraphicalPath.GetBounds().Width;
            return loc.X >= width - stroke && loc.X <= width;
        }
        bool NearBottom(Point loc)
        {
            float height = GraphicalPath.GetBounds().Height;
            return loc.Y >= height - stroke && loc.Y <= height;
        }
        static bool NearLeft(Point loc)
        {
            return loc.X >= 0 && loc.X <= stroke;
        }

    }
}

using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
    public class LightingLabel : Label, ILighting
    {
        Form form;
        Image none, lighting, active;

        public Color ActiveColor { get; set; }
        public Color NoneColor { get; set; }
        public Color LightingColor { get; set; }
        public Form Form
        {
            get { return form; }
            set
            {
                if (value == null) return;
                form = value;
                form.Load += form_Load;
                form.Deactivate += (sender, e) => LightOff();
            }
        }
        public override bool AutoSize { get { return false; } set { base.AutoSize = value; } }
        public override string Text { get { return string.Empty; } set { base.Text = value; } }

        public LightingLabel()
        {
            Padding = new Padding(2);
            ActiveColor = SystemColors.MenuHighlight;
            LightingColor = Color.Gold;
            NoneColor = SystemColors.WindowFrame;
        }

        public void ActiveOn()
        {
            Image = active;
        }
        public void LightOn()
        {
            Image = lighting;
        }
        public void LightOff()
        {
            Image = none;
        }
        public bool CanLight()
        {
            return Enabled && form.ActiveControl != this;
        }
        public bool IsInside()
        {
            Point p = PointToClient(MousePosition);
            int x = p.X, y = p.Y;
            return x > 0 && x < Width && y > 0 && y < Height;
        }
        void CreateImages()
        {
            none = CreateImage(NoneColor);
            lighting = CreateImage(LightingColor);
            active = CreateImage(ActiveColor);
        }
        Image CreateImage(Color c)
        {
            Bitmap bmp = new Bitmap(Width + 1, Height + 1);
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.FillRectangle(new SolidBrush(c), ClientRectangle);
                gr.FillRectangle(new SolidBrush(BackColor), Padding.Left, Padding.Top,
                                 Width - Padding.Left - Padding.Right, Height - Padding.Top - Padding.Bottom);
            }
            return bmp;
        }
        void form_Load(object sender, System.EventArgs e)
        {
            CreateImages();
            Layout += LightingLabel_Layout;
        }
        void LightingLabel_Layout(object sender, LayoutEventArgs e)
        {
            bool isActive = Image == active;
            CreateImages();
            if (isActive) Image = active;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
    public partial class LightingControl : UserControl, ILighting
    {
        Form form;
        Image none, lighting, active;

        public Color ActiveColor { get; set; }
        public Color NoneColor { get; set; }
        public Color LightingColor { get; set; }
        public virtual Form Form
        {
            get { return form; }
            set
            {
                form = value;
                if (value == null) return;
                form.Load += form_Load;
                form.Activated += form_Activated;
                form.Deactivate += control_Leave;
            }
        }

        public LightingControl()
        {
            InitializeComponent();
            ActiveColor = SystemColors.MenuHighlight;
            LightingColor = Color.Gold;
            NoneColor = SystemColors.WindowFrame;
        }

        public void LightActive()
        {
            BackgroundImage = active;
        }
        public void LightOn()
        {
            BackgroundImage = lighting;
        }
        public void LightOff()
        {
            BackgroundImage = none;
        }
        public bool CanLight()
        {
            return Enabled && form.ActiveControl != this && BackgroundImage != active;
        }
        public bool IsInside()
        {
            Point p = PointToClient(MousePosition);
            int x = p.X, y = p.Y;
            return x > 0 && x < Width && y > 0 && y < Height;
        }
        protected override void OnEnter(EventArgs e)
        {
            LightActive();
            base.OnEnter(e);
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            bool isActive = BackgroundImage == active;
            CreateImages();
            if (isActive) BackgroundImage = active;
            base.OnLayout(e);
        }
        protected void ControlMouseEnter(object sender, EventArgs e)
        {
            if (CanLight()) LightOn();
        }
        protected void ControlMouseLeave(object sender, EventArgs e)
        {
            if (BackgroundImage != active && !IsInside()) LightOff();
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
        void CreateImages()
        {
            none = CreateImage(NoneColor);
            lighting = CreateImage(LightingColor);
            active = CreateImage(ActiveColor);
        }
        void form_Load(object sender, EventArgs e)
        {
            CreateImages();
        }
        void form_Activated(object sender, EventArgs e)
        {
            if (form.ActiveControl == this) LightActive();
            else control_Leave(sender, e);
        }
        private void control_Leave(object sender, EventArgs e)
        {
            BackgroundImage = none;
        }
        protected virtual void ControlEnter(object sender, EventArgs e)
        {
            LightActive();
        }
    }
}

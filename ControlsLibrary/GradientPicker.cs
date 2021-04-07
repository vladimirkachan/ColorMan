using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ExtensionLibrary;

namespace ColorMan.ControlsLibrary
{
    public partial class GradientPicker : UserControl, IColorSpace
    {
        Color color1, color2, pickedColor;
        bool isDowned;
        int x;
        double kx;

        public Color PickedColor { get { return pickedColor; } }
        public IBaseSpace Space { get { return new Rgb(pickedColor); } }
        public bool IsPicked { get; private set; }
        public Color Color1
        {
            get { return color1; }
            set
            {
                color1 = value;
                CreateImage();
                SetPickedColor();
            }
        }
        public Color Color2
        {
            get { return color2; }
            set
            {
                color2 = value;
                CreateImage();
                SetPickedColor();
            }
        }

        public GradientPicker()
        {
            InitializeComponent();
            pictureBox1.Cursor = new Cursor(GetType(), "Pipette.cur");
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            int w = Width - label1.Width, h = Height - label1.Height;
            pictureBox1.Size = new Size(w, h);
            label1.Location = new Point((int)(w * kx), h);
            LocateLabel2();
            CreateImage();
        }
        void CreateImage()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics gr = Graphics.FromImage(bmp))
                gr.FillRectangle(new LinearGradientBrush(Point.Empty, new Point(pictureBox1.Width), color1, color2),
                                 pictureBox1.ClientRectangle);
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            pictureBox1.Image = bmp;
        }
        void LocateLabel2()
        {
            label2.Location = new Point(kx < 0.5 ? label1.Right : label1.Left - label2.Width, Height - label2.Height);
        }
        void Pick(MouseEventArgs e)
        {
            int w = pictureBox1.Width;
            x = e.X.CutRange(0, w - 1);
            kx = (double)x / w;
            SetPickedColor();
            label1.Left = x;
            LocateLabel2();
            label2.Text = kx.ToString("p0", CultureInfo.InvariantCulture);
        }
        void SetPickedColor()
        {
            pickedColor = new Bitmap(pictureBox1.Image).GetPixel(x, 5);
            toolTip1.SetToolTip(label1, pickedColor.ToHex().ToUpperInvariant());
            label1.Invalidate();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Visible = isDowned = true;
            Pick(e);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDowned) Pick(e);
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDowned = false;
        }
        private void label1_Paint(object sender, PaintEventArgs e)
        {
            int w = label1.Width - 3, h = label1.Height - 3;
            e.Graphics.FillEllipse(Brushes.Black, 0, 0, w, h);
            e.Graphics.FillEllipse(Brushes.White, 2, 2, w - 4, h - 4);
            e.Graphics.FillEllipse(new SolidBrush(pickedColor), 3, 3, w - 6, h - 6);
        }
        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            label2.Visible = label1.Visible;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            IsPicked = true;
            OnMouseDown(e);
            IsPicked = false;
        }
        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            var source = e.Data.GetData(GetType());
            e.Effect = source == this ? DragDropEffects.Move : DragDropEffects.None;
        }
        private void copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pickedColor.ToHex().ToUpperInvariant());
        }
    }
}

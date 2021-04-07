using System;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ColorSpaces;

namespace ColorMan.ControlsLibrary
{
    public partial class ColorLabel : UserControl, IColorSpace
    {
        public event EventHandler ColorChanged;
        public event EventHandler SpaceChanged;
        readonly SolidBrush brush = new SolidBrush(Color.Gold);
        IBaseSpace space = Rgb.Empty;

        public Color Color { get { return Space.ToColor(); } set { if (Color != value) SetColor(value); } }
        public IBaseSpace Space
        {
            get { return space; }
            set
            {
                if (value == null || space.Equals(value)) return;
                space = value;
                label1.BackColor = value.ToColor();
                toolTip1.SetToolTip(label1, value.ToString());
                OnSpaceChanged(EventArgs.Empty);
            }
        }
        public float Stroke { get; set; }
        public Color LightingColor { get { return brush.Color; } set { brush.Color = value; } }
        public string TypeAndHex
        {
            get { return Space.GetType().Name.ToUpperInvariant() + " " + Space.Hex; }
            set { TrySetTypeAndHex(value); }
        }

        public ColorLabel()
        {
            InitializeComponent();
            label1.Image = new Bitmap(Width, Height);
            Stroke = 2;
        }

        public bool TrySetTypeAndHex(string input)
        {
            IBaseSpace val;
            if (!SpaceParser.TryGetSpaceFromTypeAndHex(input, out val)) return false;
            Space = val;
            return true;
        }
        void SetColor(Color color)
        {
            Space = space.Create(color);
        }
        void OnColorChanged(EventArgs e)
        {
            if (ColorChanged != null) ColorChanged(this, e);
        }
        void OnSpaceChanged(EventArgs e)
        {
            if (SpaceChanged != null) SpaceChanged(this, e);
        }
        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            drgevent.Effect = DragDropEffects.Move;
            object source = drgevent.Data.GetData(GetType());
            if (source != this) LightOn();
            base.OnDragEnter(drgevent);
        }
        protected override void OnDragLeave(EventArgs e)
        {
            LightOff();
            base.OnDragLeave(e);
        }
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            LightOff();
            base.OnDragDrop(drgevent);
        }
        void LightOn()
        {
            int w = label1.Width, h = label1.Height;
            if (label1.Image != null) label1.Image.Dispose();
            label1.Image = new Bitmap(w, h);
            using (Graphics gr = Graphics.FromImage(label1.Image))
            {
                gr.Clear(label1.BackColor);
                gr.FillRectangle(brush, 0, 0, w, Stroke);
                gr.FillRectangle(brush, w - Stroke, 0, Stroke, h);
                gr.FillRectangle(brush, 0, h - Stroke, w, h);
                gr.FillRectangle(brush, 0, 0, Stroke, h);
            }
            label1.Invalidate();
        }
        void LightOff()
        {
            label1.Image = null;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);
        }
        private void label1_BackColorChanged(object sender, EventArgs e)
        {
            OnColorChanged(e);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}

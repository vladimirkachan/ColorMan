using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]
namespace ColorMan.ControlsLibrary
{
    public class BaseColorBox : PictureBox, IDirectedCrement
    {
        public event EventHandler ValueChanged;
        public event EventHandler LastValue;
        int colorCount = 2;
        Color[] colors = new Color[2];
        float[] positions = new float[2];
        readonly ColorBlend blend = new ColorBlend();
        protected Brush Brush1 { get; set; }
        protected Point MouseLocation { get; set; }
        public Func<Brush> BrushFunc { get; set; }
        public Func<Point, float> BrightnessUnderTheCursorFunc { get; set; }
        public Func<Color> SelectedColorFunc { get; set; }
        public bool IsDowned { get; protected set; }
        public bool IsRightDowned { get; set; }
        public bool Inside { get; protected set; }
        protected Cursor CircleCursor {get; set;}

        protected BaseColorBox()
        {
            CircleCursor = new Cursor(GetType(), "DefaultCircle.cur");
            Cursor = CircleCursor;
        }
        public void SetColors(Color[] value)
        {
            colors = value;
        }
        public Color[] GetColors()
        {
            return colors;
        }
        public virtual Color CenterColor { get; set; }
        public int ColorCount
        {
            get { return colorCount; }
            set
            {
                colorCount = value;
                RechangeColorCount(value);
            }
        }
        protected virtual void RechangeColorCount(int count)
        {
            positions = new float[count];
            colors = new Color[count];
            for (int i = 0; i < count; i++) positions[i] = (float)i / (count - 1);
            blend.Positions = positions;
        }
        public float[] GetPositions()
        {
            return positions;
        }
        public virtual Brush UpdatedBrush()
        {
            blend.Colors = colors;
            ((LinearGradientBrush)Brush1).InterpolationColors = blend;
            return Brush1;
        }
        public virtual void ToUp() { }
        public virtual void ToDown() { }
        public virtual void ToLeft() { }
        public virtual void ToRight() { }
        protected virtual void ValFromPosition() { }
        protected void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(this, e);
        }
        protected void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            OnLastValue(e);
        }
    }
}


using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.ControlsLibrary
{
	public partial class Pointer : UserControl
	{
	    Point[] pp1 = new Point[3];
	    Point[] pp2 = new Point[3];
	    readonly int pad;
        double val;
        double minimum, maximum = 100.0;
        
        public virtual double Val
        {
            get { return val; }
            set
            {
                val = value;
                LabelLocate();
            }
        }
        public double Minimum { get { return minimum; } set { minimum = value; } }
        public double Maximum { get { return maximum; } set { maximum = value; } }
        protected double Range { get { return Maximum - Minimum; } }
        public virtual int Side { get; set; }
	    protected int Pad { get { return pad; } }

	    public Pointer()
        {
            InitializeComponent();
        }

        protected Point[] GetPP1()
	    {
	        return pp1;
	    }
	    protected Point[] GetPP2()
	    {
	        return pp2;
	    }
	    protected Pointer(int pad) : this()
        {
            this.pad = pad;
        }
        protected virtual void LabelLocate() { }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPolygon(Brushes.White, pp1);
            e.Graphics.FillPolygon(Brushes.Black, pp2);
        }
	}
}

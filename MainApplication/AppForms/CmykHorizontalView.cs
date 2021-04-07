using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    public partial class CmykHorizontalView : View
    {
        public CmykHorizontalView()
        {
            InitializeComponent();
            Packs.Add(new Pack(cnud1, ctbar1, hcbox1));
            Packs.Add(new Pack(cnud2, ctbar2, hcbox2));
            Packs.Add(new Pack(cnud3, ctbar3, hcbox3));
            Packs.Add(new Pack(cnud4, ctbar4, hcbox4));
            SetColorBoxesBrushes();
            ctbar1.Tag = light1;
            ctbar2.Tag = light2;
            ctbar3.Tag = light3;
            ctbar4.Tag = light4;
            hcbox1.Tag = ctbar1;
            hcbox2.Tag = ctbar2;
            hcbox3.Tag = ctbar3;
            hcbox4.Tag = ctbar4;
            cnud1.Tag = lightN1;
            cnud2.Tag = lightN2;
            cnud3.Tag = lightN3;
            cnud4.Tag = lightN4;
            SetLightings(new ILighting[] {light1, light2, light3, light4, lightN1, lightN2, lightN3, lightN4});
        }
        void SetColorBoxesBrushes()
        {
            hcbox1.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(hcbox1.Val, hcbox2.Val, hcbox3.Val, hcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox1.Width, 0f), cmyk.C1, cmyk.C2);
            };
            hcbox2.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(hcbox1.Val, hcbox2.Val, hcbox3.Val, hcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox2.Width, 0f), cmyk.M1, cmyk.M2);
            };
            hcbox3.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(hcbox1.Val, hcbox2.Val, hcbox3.Val, hcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox3.Width, 0f), cmyk.Y1, cmyk.Y2);
            };
            hcbox4.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(hcbox1.Val, hcbox2.Val, hcbox3.Val, hcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbox4.Width, 0f), cmyk.K1, Cmyk.K2);
            };
        }
        public void Hcbox1ValueChanged(object sender, EventArgs e)
        {
            hcbox2.Invalidate();
            hcbox3.Invalidate();
            hcbox4.Invalidate();
        }
        public void Hcbox2ValueChanged(object sender, EventArgs e)
        {
            hcbox1.Invalidate();
            hcbox3.Invalidate();
            hcbox4.Invalidate();
        }
        public void Hcbox3ValueChanged(object sender, EventArgs e)
        {
            hcbox1.Invalidate();
            hcbox2.Invalidate();
            hcbox4.Invalidate();
        }
        public void Hcbox4ValueChanged(object sender, EventArgs e)
        {
            hcbox1.Invalidate();
            hcbox2.Invalidate();
            hcbox3.Invalidate();
        }
        void ActiveControlActiveOn()
        {
            var lightingLabel = ActiveControl.Tag as LightingLabel;
            if (lightingLabel != null) lightingLabel.ActiveOn();
        }
        protected override void OnActivated(EventArgs e)
        {
            ActiveControlActiveOn();
            base.OnActivated(e);
        }
        private void hcbox_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = ((Control)sender).Tag as Control;
        }
        private void ctrl_Enter(object sender, EventArgs e)
        {
            ActiveControlActiveOn();
        }
        private void ctrl_Leave(object sender, EventArgs e)
        {
            var lightingLabel = ((Control)sender).Tag as LightingLabel;
            if (lightingLabel != null) lightingLabel.LightOff();
        }
        private void item_LastValue(object sender, EventArgs e)
        {
            History.Instance.SetCurrentValue(TwoColorton.Instance.Space1);
        }
   }
}

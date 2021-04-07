using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    public partial class CmykVerticalView : View
    {
        public CmykVerticalView()
        {
            InitializeComponent();
            Packs.Add(new Pack(cnud1, ctbar1, vcbox1));
            Packs.Add(new Pack(cnud2, ctbar2, vcbox2));
            Packs.Add(new Pack(cnud3, ctbar3, vcbox3));
            Packs.Add(new Pack(cnud4, ctbar4, vcbox4));
            SetColorBoxesBrushes();
            ctbar1.Tag = light1;
            ctbar2.Tag = light2;
            ctbar3.Tag = light3;
            ctbar4.Tag = light4;
            vcbox1.Tag = ctbar1;
            vcbox2.Tag = ctbar2;
            vcbox3.Tag = ctbar3;
            vcbox4.Tag = ctbar4;
            cnud1.Tag = lightN1;
            cnud2.Tag = lightN2;
            cnud3.Tag = lightN3;
            cnud4.Tag = lightN4;
            SetLightings(new ILighting[] {light1, light2, light3, light4, lightN1, lightN2, lightN3, lightN4});
        }
        void SetColorBoxesBrushes()
        {
            vcbox1.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(vcbox1.Val, vcbox2.Val, vcbox3.Val, vcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, vcbox1.Height), new PointF(0f, 0f), cmyk.C1, cmyk.C2);
            };
            vcbox2.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(vcbox1.Val, vcbox2.Val, vcbox3.Val, vcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, vcbox2.Height), new PointF(0f, 0f), cmyk.M1, cmyk.M2);
            };
            vcbox3.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(vcbox1.Val, vcbox2.Val, vcbox3.Val, vcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, vcbox3.Height), new PointF(0f, 0f), cmyk.Y1, cmyk.Y2);
            };
            vcbox4.BrushFunc = () =>
            {
                Cmyk cmyk = new Cmyk(vcbox1.Val, vcbox2.Val, vcbox3.Val, vcbox4.Val);
                return new LinearGradientBrush(new PointF(0f, vcbox4.Height), new PointF(0f, 0f), cmyk.K1, Cmyk.K2);
            };
        }
        public void Vcbox1ValueChanged(object sender, EventArgs e)
        {
            vcbox2.Invalidate();
            vcbox3.Invalidate();
            vcbox4.Invalidate();
        }
        public void Vcbox2ValueChanged(object sender, EventArgs e)
        {
            vcbox1.Invalidate();
            vcbox3.Invalidate();
            vcbox4.Invalidate();
        }
        public void Vcbox3ValueChanged(object sender, EventArgs e)
        {
            vcbox1.Invalidate();
            vcbox2.Invalidate();
            vcbox4.Invalidate();
        }
        public void Vcbox4ValueChanged(object sender, EventArgs e)
        {
            vcbox1.Invalidate();
            vcbox2.Invalidate();
            vcbox3.Invalidate();
        } 
        private void vcbox_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = ((Control)sender).Tag as Control;
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

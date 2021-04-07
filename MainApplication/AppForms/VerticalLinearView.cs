using System;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    public partial class VerticalLinearView : View
    {
        public VerticalLinearView()
        {
            InitializeComponent();
            Packs.Add(new Pack(vcbox1, ctbar1, ctbox1, cnud1));
            Packs.Add(new Pack(vcbox2, ctbar2, ctbox2, cnud2));
            Packs.Add(new Pack(vcbox3, ctbar3, ctbox3, cnud3));
            ctbar1.Tag = light1;
            ctbar2.Tag = light2;
            ctbar3.Tag = light3;
            cnud1.Tag = lightN1;
            cnud2.Tag = lightN2;
            cnud3.Tag = lightN3;
            ctbox1.Tag = lightT1;
            ctbox2.Tag = lightT2;
            ctbox3.Tag = lightT3;
            vcbox1.Tag = ctbar1;
            vcbox2.Tag = ctbar2;
            vcbox3.Tag = ctbar3;
            SetLightings(new ILighting[] {light1, light2, light3, lightN1, lightN2, lightN3, lightT1, lightT2, lightT3});
        }
        public void Vcbox1ValueChanged(object sender, EventArgs e)
        {
            vcbox2.Invalidate();
            vcbox3.Invalidate();
        }
        public void Vcbox2ValueChanged(object sender, EventArgs e)
        {
            vcbox1.Invalidate();
            vcbox3.Invalidate();
        }
        public void Vcbox3ValueChanged(object sender, EventArgs e)
        {
            vcbox1.Invalidate();
            vcbox2.Invalidate();
        }
        protected override void OnActivated(EventArgs e)
        {
            ActiveControlActiveOn();
            base.OnActivated(e);
        }
        void ActiveControlActiveOn()
        {
            var lightingLabel = ActiveControl.Tag as LightingLabel;
            if (lightingLabel != null) lightingLabel.ActiveOn();
        }
        private void vcbox_MouseDown(object sender, MouseEventArgs e)
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

using System;
using System.Windows.Forms;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    public partial class HorizontalLinearView : View
    {
        public HorizontalLinearView()
        {
            InitializeComponent();
            Packs.Add(new Pack(hcbox1, ctbar1, ctbox1, cnud1));
            Packs.Add(new Pack(hcbox2, ctbar2, ctbox2, cnud2));
            Packs.Add(new Pack(hcbox3, ctbar3, ctbox3, cnud3));
            ctbar1.Tag = light1;
            ctbar2.Tag = light2;
            ctbar3.Tag = light3;
            hcbox1.Tag = ctbar1;
            hcbox2.Tag = ctbar2;
            hcbox3.Tag = ctbar3;
            cnud1.Tag = lightN1;
            cnud2.Tag = lightN2;
            cnud3.Tag = lightN3;
            ctbox1.Tag = lightT1;
            ctbox2.Tag = lightT2;
            ctbox3.Tag = lightT3;
            SetLightings(new ILighting[] {light1, light2, light3, lightN1, lightN2, lightN3, lightT1, lightT2, lightT3});
        }

        public void Hcbox1ValueChanged(object sender, EventArgs e)
        {
            hcbox2.Invalidate();
            hcbox3.Invalidate();
        }
        public void Hcbox2ValueChanged(object sender, EventArgs e)
        {
            hcbox1.Invalidate();
            hcbox3.Invalidate();
        }
        public void Hcbox3ValueChanged(object sender, EventArgs e)
        {
            hcbox1.Invalidate();
            hcbox2.Invalidate();
        }
        private void hcbox_MouseDown(object sender, MouseEventArgs e)
        {
            ActiveControl = ((Control)sender).Tag as Control;
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
        void ActiveControlActiveOn()
        {
            var lightingLabel = ActiveControl.Tag as LightingLabel;
            if (lightingLabel != null) lightingLabel.ActiveOn();
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

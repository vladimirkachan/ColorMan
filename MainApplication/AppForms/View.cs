using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ControlsLibrary;
using ColorMan.ExtensionLibrary;
using ColorMan.Properties;

namespace ColorMan.AppForms
{
    public partial class View : Form
    {
        Collection<Pack> packs = new Collection<Pack>();
        Cursor dragCur;
        ToolStripItem element;
        ILighting[] lightings;
        public Pack this[int index] { get { return packs[index]; } }
        public View Pair { get; set; }
        static TwoColorton Tc { get { return TwoColorton.Instance; } }
        protected Collection<Pack> Packs { get { return packs; } }

        public View()
        {
            InitializeComponent();
            Tc.SpaceSwapped += TcSpaceSwapped;
            Tc.Space1Changed += TcSpace1Changed;
            Tc.Space2Changed += TcSpace2Changed;
        }

        public void SetMenuItemElement(ToolStripItem item)
        {
            element = item;
        }
        protected void SetLightings(ILighting[] wraps)
        {
            lightings = wraps;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.X: e.SuppressKeyPress = true; Tc.Swap(); break;
                case Keys.R: if (e.Alt) e.SuppressKeyPress = true;
                    Rotate(new Point(Width / 2, Height / 2)); break;
            }
            base.OnKeyDown(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
            base.OnFormClosing(e);
        }
        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            gfbevent.UseDefaultCursors = false;
            Cursor.Current = gfbevent.Effect == DragDropEffects.Move ? dragCur : Cursors.No;
            base.OnGiveFeedback(gfbevent);
        }
        protected override void OnLoad(EventArgs e)
        {
            var mainForm = Owner as MainForm;
            if (mainForm != null) colorLabel1.ContextMenuStrip = colorLabel2.ContextMenuStrip = mainForm.cms_colorLabel12;
            base.OnLoad(e);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            timer1.Enabled = Visible && lightings != null && lightings.Length > 0;
            if (element == null) return;
            var visible = Pair == null ? Visible : Visible || Pair.Visible;
            element.Image = visible ? Resources.hide : Resources.open;
        }
        protected virtual void CmsViewOpening(object sender, CancelEventArgs e)
        {
            rotate1.Enabled = Pair != null;
        }
        protected virtual void SetPairBounds()
        {
            Pair.Size = Size.Invert();
        }
        void Rotate(Point click)
        {
            if (Pair == null) return;
            SetPairBounds();
            Allocate(click);
        }
        void Allocate(Point click)
        {
            Point scr = PointToScreen(click);
            Pair.Location = scr - new Size(click.Y, click.X);
            PairToScreenBounds();
            if (ActiveControl != null) Pair.SetActiveControl(ActiveControl.Name);
            Hide();
            Pair.Show();
        }
        void PairToScreenBounds()
        {
            Point loc = Pair.Location;
            int x = loc.X, y = loc.Y, w = Pair.Width, h = Pair.Height;
            int screenWidth = LocalScreen.Width, screenHeight = LocalScreen.Height;
            Pair.Location = new Point(x < 0 ? 0 : x + w > screenWidth ? screenWidth - w : x,
                y < 0 ? 0 : y + h > screenHeight ? screenHeight - h : y);
        }
        void SetActiveControl(string name)
        {
            Control ctrl = Controls[name];
            if (ctrl != null) ActiveControl = ctrl;
        }
        void TcSpace1Changed(object sender, EventArgs e)
        {
            colorLabel1.Space = Tc.Space1;
        }
        void TcSpace2Changed(object sender, EventArgs e)
        {
            colorLabel2.Space = Tc.Space2;
        }
        void TcSpaceSwapped(object sender, EventArgs e)
        {
            colorLabel1.Space = Tc.Space1;
            colorLabel2.Space = Tc.Space2;
        }
        private void colorLabel1_DragDrop(object sender, DragEventArgs e)
        {
            ((MainForm)Owner).ColorLabel1DragDrop(sender, e);
        }
        private void colorLabel2_DragDrop(object sender, DragEventArgs e)
        {
            ((MainForm)Owner).ColorLabel2DragDrop(sender, e);
        }
        private void colorLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var mainForm = (MainForm)Owner;
                mainForm.dragType = sender.GetType();
                dragCur = ((IColorSpace)sender).Space.CreateCursor();
                DoDragDrop(sender, DragDropEffects.Move);
            }
        }
        private void exitColorMan1_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }
        private void closeWindow1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void gotoMainColorMan1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Owner.OwnedForms) f.Hide();
            Owner.Focus();
        }
        private void rotate1_Click(object sender, EventArgs e)
        {
            Rotate(new Point(Width / 2, Height / 2));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var l in lightings.Where(l => l.CanLight()))
                if (l.IsInside()) l.LightOn();
                else l.LightOff();
        }
    }
}

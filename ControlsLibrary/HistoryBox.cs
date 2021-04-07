using System;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ControlsLibrary.Properties;

namespace ColorMan.ControlsLibrary
{
    public enum HistoryBoxActionMode { Back, Forward }

    public partial class HistoryBox : LightingControl
    {
        HistoryBoxActionMode mode;
        public HistoryBoxActionMode Mode
        {
            get { return mode; }
            set
            {
                mode = value;
                label1.Image = value == HistoryBoxActionMode.Back ? Resources.back : Resources.forward;
            }
        }
        public event EventHandler Execute;
        Color backgroundColor;
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                comboBox1.BackColor = label1.BackColor = BackColor = value;
            }
        }
        public Color MouseDownBackColor { get; set; }
        public Color MouseOverBackColor { get; set; }
        IBaseSpace this[int index]
        {
            get
            {
                return index > -1 && index < Count ? (IBaseSpace)comboBox1.Items[index] : null;
            }
        }
        int Count { get { return comboBox1.Items.Count; } }
        public int SelectedIndex { get; set; }

        public HistoryBox()
        {
            InitializeComponent();
            MouseDownBackColor = Color.FromArgb(102, 153, 204);
            MouseOverBackColor = Color.FromArgb(154, 147, 103);
        }
        public void Push(IBaseSpace value)
        {
            if (value != null)
            {
                comboBox1.Items.Insert(0, value);
                Enabled = Count > 0;
            }
        }
        public IBaseSpace Pop()
        {
            if (Count > 0)
            {
                var value = this[0];
                comboBox1.Items.RemoveAt(0);
                Enabled = Count > 0;
                return value;
            }
            throw new InvalidOperationException();
        }
        void OnExecute(EventArgs e)
        {
            if (Execute != null) Execute(this, e);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                case Keys.Space: OnExecute(null); return true;
                case Keys.Left:
                case Keys.Right: comboBox1.DroppedDown = !comboBox1.DroppedDown; return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            int i = e.Index;
            var bounds = e.Bounds;
            if (i != -1)
                e.Graphics.FillRectangle(new SolidBrush(((IBaseSpace)comboBox1.Items[i]).ToColor()),
                    bounds.Left, bounds.Top, bounds.Height, bounds.Height);
            e.DrawFocusRectangle();
        }
        private void comboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            comboBox1.ItemHeight = 20;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            SelectedIndex = 0;
            OnExecute(e);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = comboBox1.SelectedIndex;
            OnExecute(e);
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = MouseOverBackColor;
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Focus();
            label1.BackColor = MouseDownBackColor;
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.BackColor = backgroundColor;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = backgroundColor;
        }

    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ColorMan.AppForms
{
    public partial class TextEnterForm : Form
    {
        public event EventHandler TextEntered;
        readonly GraphicsPath graphicsPath = new GraphicsPath();
        string text, space;
        int currentIndex;
        readonly Color activeForeColor = Color.White, activeBackColor = Color.FromArgb(64, 64, 64),
            deactiveForeColor = Color.Black, deactiveBackColor = Color.Gray;
        readonly SolidBrush activeForeBrush = (SolidBrush)Brushes.White, deactiveForeBrush = (SolidBrush)Brushes.Black;

        public string InputText
        {
            get { return comboBox1.SelectedItem + " " + textBox1.Text; }
            set
            {
                string[] s = value.Split();
                comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
                textBox1.TextChanged -= textBox1_TextChanged;
                comboBox1.SelectedItem = space = s[0];
                currentIndex = comboBox1.SelectedIndex;
                textBox1.Text = text = s[1].ToUpperInvariant();
                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
                textBox1.TextChanged += textBox1_TextChanged;
            }
        }

        public TextEnterForm()
        {
            InitializeComponent();
            graphicsPath.AddRectangle(panel1.Bounds);
            Region = new Region(graphicsPath);
            comboBox1.DrawItem += comboBox1_DrawItem;
            textBox1.Select(textBox1.TextLength, 0);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        protected override void OnDeactivate(EventArgs e)
        {
            Hide();
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            ActiveControl = textBox1;
            button1.Visible = Visible;
            button1.Enabled = false;
            errorProvider1.SetError(textBox1, "");
            textBox1.Select(textBox1.TextLength, 0);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (textBox1.Focused)
            {
                switch (keyData)
                {
                    case Keys.Up: Crement(1); return true;
                    case Keys.Down: Crement(-1); return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        void Crement(int delta)
        {
            int pos = textBox1.SelectionStart - 1;
            StringBuilder sb = new StringBuilder(textBox1.Text);
            string s = sb[pos].ToString();
            int x = Convert.ToInt32(s, 16);
            s = ((x + delta) % 16).ToString("X", CultureInfo.InvariantCulture);
            sb[pos] = s[0];
            textBox1.Text = sb.ToString();
            textBox1.SelectionStart = pos + 1;
        }
        void OnTextEntered(EventArgs e)
        {
            if (TextEntered != null) TextEntered(this, e);
        }
        void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index;
            var items = comboBox1.Items;
            var graphics = e.Graphics;
            var bounds = e.Bounds;
            string item = items[index].ToString();
            var font = comboBox1.Font;
            if (comboBox1.DroppedDown) e.DrawBackground();
            graphics.DrawString(item, font, index == currentIndex && comboBox1.Focused ?
                activeForeBrush : deactiveForeBrush, bounds);
            e.DrawFocusRectangle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OnTextEntered(e);
            Hide();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = c;
            e.Handled = !(char.IsDigit(c) || (i > 64 && i < 71) || (i > 96 && i < 103) || c == (char)(Keys.Back));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool len = textBox1.TextLength == 6;
            button1.Visible = len;
            button1.Enabled = textBox1.Text != text && len;
            errorProvider1.SetError(textBox1, len ? string.Empty : "Text should be 6 characters");
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = activeBackColor;
            textBox1.ForeColor = activeForeColor;
            textBox1.Select(textBox1.TextLength, 0);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = comboBox1.SelectedItem.ToString() != space && textBox1.TextLength == 6;
            currentIndex = comboBox1.SelectedIndex;
            comboBox1.Invalidate();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = deactiveBackColor;
            textBox1.ForeColor = deactiveForeColor;
        }
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.BackColor = activeBackColor;
        }
        private void comboBox1_Leave(object sender, EventArgs e)
        {
            comboBox1.BackColor = deactiveBackColor;
        }
        private void ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: if (button1.Enabled) { OnTextEntered(e); Hide(); } e.SuppressKeyPress = true; break;
                case Keys.Escape: Hide(); break;
            }
        }
    }
}

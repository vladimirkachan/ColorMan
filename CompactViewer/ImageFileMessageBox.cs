using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ColorMan.CompactViewer
{
    public partial class ImageFileMessageBox : Form
    {
        public ImageFileMessageBox(string text, string caption, Image icon) : this()
        {
            labelText.Text = text;
            Text = caption;
            labelIcon.Image = icon;
        }
        ImageFileMessageBox()
        {
            InitializeComponent();
        }

        public void SetImageFile(string path)
        {
            var image = Image.FromFile(path);
            pictureBox1.Image = image;
            labelInfo.Text = string.Format(CultureInfo.InvariantCulture,
                "{0}\nImage size:  {1}x{2}\nSize: {3} Kb", Path.GetFileName(path), image.Width,
                image.Height, new FileInfo(path).Length / 1024);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}

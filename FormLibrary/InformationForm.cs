using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]
namespace ColorMan.FormLibrary
{
    public partial class InformationForm : Form
    {
        public InformationForm(Image icon, string name) : this()
        {
            labelIcon.Image = icon;
            labelName.Text = name;
            Text = @"About " + Process.GetCurrentProcess().ProcessName;
        }
        public InformationForm()
        {
            InitializeComponent();
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            if (Visible) ActiveControl = linkLabelWebsite;
        }
        private void cbuttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void linkLabelWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/vladimirkachan");
            ((LinkLabel)sender).LinkVisited = true;
        }
        private void linkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"mailto:victorhulcko@gmail.com");
            ((LinkLabel)sender).LinkVisited = true;
        }
        private void cbuttonDonate_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.paypal.com/donate?hosted_button_id=K69MC7RVVU2JA");
        }
    }
}

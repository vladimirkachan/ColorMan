using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Windows.Forms;
using ColorMan.ColorPicker.Properties;
using ColorMan.ExtensionLibrary;
using ColorMan.FormLibrary;
using CommonExtension = ColorMan.ExtensionLibrary.Extension;

[assembly: CLSCompliant(true)]
namespace ColorMan.ColorPicker
{
    public enum ColorPickerDirectingPlace
    {
        Right,
        Left,
        Match
    }

    public partial class ColorPickerForm : Form
    {
        ColorPickerDirectingPlace directingPlace;
        public const string AppRegKey = Hkey.RootKey + "\\" + Hkey.ColorPicker;
        const string CmStart = "&ColorMan Start", CmSend = "&ColorMan Send", Error = "Error";
        readonly Color activeForeColor = Color.White, activeBackColor = Color.FromArgb(64, 64, 64),
                               deactiveForeColor = Color.Black, deactiveBackColor = Color.LightGray,
                               activeBorderColor = SystemColors.MenuHighlight, noneBorderColor = SystemColors.WindowFrame,
                               lightingBorderColor = Color.Gold;
        Point cursorPosition;
        readonly BinaryFormatter binaryFormatter = new BinaryFormatter();
        readonly InformationForm colorPickerInfo = new InformationForm(Resources.colorPicker128,
                                                                       Hkey.ColorPicker);
        GraphicsPath graphicalPath;
        bool running = true, downed;
        Size def;
        readonly ToolStripMenuItem unvisibleForm2, ontop2, smooth2;

        public ColorPickerForm()
        {
            InitializeComponent();
            unvisibleForm2 = new ToolStripMenuItem("&Unvisible Form", null, ChangeRegion, Keys.F10) { CheckOnClick = true };
            ontop2 = new ToolStripMenuItem("On&Top", null, ontop_CheckedChanged, Keys.F2) { CheckOnClick = true };
            smooth2 = new ToolStripMenuItem("S&mooth Picture", null, smooth_CheckedChanged, zoomViewer1.SmoothKey)
            { CheckOnClick = true };
            zoomViewer1.Cms.Items.AddRange(new ToolStripItem[] { ontop2, unvisibleForm2, smooth2 });
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            RegistryWrite();
            if (File.Exists(Program.MFN)) File.Delete(Program.MFN);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (!Visible) return;
            this.ToScreenBounds();
            cursorPosition = cursorPosition.ToScreenBounds();
            CommonExtension.SetMousePosition(cursorPosition.X, cursorPosition.Y);
            ActiveControl = zoomViewer1;
            if (running) zoomViewer1.Checked = true;
        }
        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            if (!drgevent.Data.GetDataPresent(DataFormats.FileDrop)) return;
            drgevent.Effect = drgevent.KeyState == 1 ? DragDropEffects.Copy : DragDropEffects.Move;
        }
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            Cursor.Current = Cursors.Default;
            LoadFile(((string[])drgevent.Data.GetData(DataFormats.FileDrop))[0]);
        }
        protected override void OnLoad(EventArgs e)
        {
            RegistryRead();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 1) return;
            running = false;
            LoadFile(args[1]);
        }
        void LoadFile(string fileName)
        {
            try
            {
                zoomViewer1.SetOuterImage(fileName);
            }
            catch (Exception)
            {
                return;
            }
        }
        void SetRegion(bool value)
        {
            graphicalPath = new GraphicsPath();
            graphicalPath.AddRectangle(new Rectangle(zoomViewer1.PictureLocation - new Size(Location),
                                                     zoomViewer1.PictureSize));
            Region = value ? new Region(graphicalPath) : null;
        }
        void RegistryRead()
        {
            try
            {
                string[] names =
                {
                    Hkey.ZoomViewerSettings, Hkey.Width, Hkey.Height, Hkey.DirectingPlace,
                    Hkey.PictureLocationX, Hkey.PictureLocationY, Hkey.PictureCenterX, Hkey.PictureCenterY, Hkey.OnTop
                };
                var data = CommonExtension.RegistryRead(AppRegKey, names);
                if (data.ContainsKey(Hkey.ZoomViewerSettings)) zoomViewer1.Setting(data[Hkey.ZoomViewerSettings].ToString());
                smooth1.Checked = smooth2.Checked = zoomViewer1.Smooth;
                if (data.ContainsKey(Hkey.Width)) Width = (int)data[Hkey.Width];
                if (data.ContainsKey(Hkey.Height)) Height = (int)data[Hkey.Height];
                if (data.ContainsKey(Hkey.PictureLocationX)) Left = (int)data[Hkey.PictureLocationX];
                if (data.ContainsKey(Hkey.PictureLocationY)) Top = (int)data[Hkey.PictureLocationY];
                if (data.ContainsKey(Hkey.DirectingPlace) &&
                Enum.TryParse(data[Hkey.DirectingPlace].ToString(), out directingPlace))
                    switch (directingPlace)
                    {
                        case ColorPickerDirectingPlace.Left:
                            Left -= Width;
                            break;
                        case ColorPickerDirectingPlace.Match:
                            Location += new Size(Location - new Size(zoomViewer1.ScreenLocation()));
                            break;
                    }
                if (data.ContainsKey(Hkey.OnTop))
                {
                    bool onTop;
                    string top = data[Hkey.OnTop].ToString();
                    if (bool.TryParse(top, out onTop)) TopMost = ontop1.Checked = ontop2.Checked = onTop;
                }
                if (data.ContainsKey(Hkey.PictureCenterX) && data.ContainsKey(Hkey.PictureCenterY))
                    cursorPosition = new Point((int)data[Hkey.PictureCenterX], (int)data[Hkey.PictureCenterY]);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        void RegistryWrite()
        {
            var data = new Dictionary<string, object>();
            data[Hkey.ZoomViewerSettings] = zoomViewer1.CurrentSettings;
            data[Hkey.PictureLocationX] = Left;
            data[Hkey.PictureLocationY] = Top;
            data[Hkey.PictureCenterX] = LocalScreen.Width / 2;
            data[Hkey.PictureCenterY] = LocalScreen.Height / 2;
            data[Hkey.Width] = Width;
            data[Hkey.Height] = Height;
            data[Hkey.DirectingPlace] = ColorPickerDirectingPlace.Right;
            data[Hkey.OnTop] = TopMost;
            CommonExtension.RegistryWrite(AppRegKey, data);

        }
        void SerializeData()
        {
            string dir = (string)CommonExtension.RegistryRead(Hkey.RootKey, Hkey.AppDataLocalFolder);
            if (dir == null) return;
            string path = dir + "\\" + Hkey.ZoomViewerDat;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write,
                                           FileShare.ReadWrite)) binaryFormatter.Serialize(fs, zoomViewer1.CurrentData);
        }
        void SwitchLights()
        {
            if (!zoomViewer1.CanLight()) return;
            if (zoomViewer1.IsInside()) zoomViewer1.LightOn();
            else zoomViewer1.LightOff();
        }
        void SwitchColorManHandler()
        {
            if (Process.GetProcessesByName(Hkey.ColorMan).Length == 0)
            {
                btnColorMan.Text = CmStart;
                colorManStart.Enabled = true;
                colorManSend.Enabled = false;
            }
            else
            {
                btnColorMan.Text = CmSend;
                colorManStart.Enabled = false;
                colorManSend.Enabled = true;
            }
        }
        void Form_ChangeRegion(object sender, EventArgs e)
        {
            SetRegion(unvisibleForm1.Checked);
        }
        private void zoomViewer1_ColorPick(object sender, EventArgs e)
        {
            var space = zoomViewer1.PickedSpace;
            colorLabel1.Space = space;
            tbHex.SetValIn(space);
        }
        private void btnColorMan_Click(object sender, EventArgs e)
        {
            btnColorMan.Enabled = false;
            Cursor = Cursors.AppStarting;
            switch (btnColorMan.Text)
            {
                case CmStart:
                    string executablePath =
                    (string)
                    CommonExtension.RegistryRead(Hkey.RootKey + "\\" + Hkey.ColorMan, Hkey.ExecutablePath);
                    if (executablePath != null) Process.Start(executablePath);
                    break;
                case CmSend:
                    SerializeData();
                    break;
            }
            Cursor = Cursors.Default;
            btnColorMan.Enabled = true;
        }
        private void btn_Enter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = activeForeColor;
            button.BackColor = activeBackColor;
            button.FlatAppearance.BorderColor = activeBorderColor;
        }
        private void btn_Leave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = deactiveForeColor;
            button.BackColor = deactiveBackColor;
            button.FlatAppearance.BorderColor = noneBorderColor;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SwitchColorManHandler();
            SwitchLights();
        }
        private void btn_MouseHover(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (!button.Focused) button.FlatAppearance.BorderColor = lightingBorderColor;
        }
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (!button.Focused) button.FlatAppearance.BorderColor = noneBorderColor;
        }
        private void ScreenPickerForm_Deactivate(object sender, EventArgs e)
        {
            zoomViewer1.Checked = false;
        }
        private void about1_Click(object sender, EventArgs e)
        {
            switch (TopMost)
            {
                case false: colorPickerInfo.ShowDialog(); break;
                case true: TopMost = false; colorPickerInfo.ShowDialog(); TopMost = true; break;
            }
        }
        private void exit1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ChangeRegion(object sender, EventArgs e)
        {
            bool value = ((ToolStripMenuItem)sender).Checked;
            unvisibleForm1.Checked = unvisibleForm2.Checked = value;
            SetRegion(value);
        }
        private void ontop_CheckedChanged(object sender, EventArgs e)
        {
            bool value = ((ToolStripMenuItem)sender).Checked;
            TopMost = ontop1.Checked = ontop2.Checked = value;
        }
        private void zoomViewer1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!unvisibleForm1.Checked) return;
            def = new Size(Location - new Size(MousePosition));
            downed = true;
            Cursor = Cursors.Default;
        }
        private void zoomViewer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!downed || !unvisibleForm1.Checked) return;
            Location = MousePosition + def;
        }
        private void zoomViewer1_MouseUp(object sender, MouseEventArgs e)
        {
            downed = false;
        }
        private void smooth_CheckedChanged(object sender, EventArgs e)
        {
            bool value = ((ToolStripMenuItem)sender).Checked;
            smooth1.Checked = smooth2.Checked = value;
            zoomViewer1.SwitchInterpolationMode(value);
        }
        private void cms_ColorPicker_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            zoomViewer1.Stop();
        }
    }
}

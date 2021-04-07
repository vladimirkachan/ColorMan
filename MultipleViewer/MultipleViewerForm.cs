using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ColorMan.ExtensionLibrary;
using ColorMan.FormLibrary;
using ColorMan.MultipleViewer.Properties;
using CommonExtension = ColorMan.ExtensionLibrary.Extension;

[assembly: CLSCompliant(true)]
namespace ColorMan.MultipleViewer
{
    public partial class MultipleViewerForm : Form
    {
        public const string AppRegKey = Hkey.RootKey + "\\" + Hkey.MultipleViewer;
        const string AppOpeningKey = AppRegKey + "\\" + Hkey.Opening, MdiLayoutMode = "MdiLayoutMode";
        static readonly string MultipleViewerOpenPath = CommonExtension.AppDataLocalFolder + "\\" + Hkey.MultipleViewerOpenDat;
        readonly InformationForm multipleViewerInfo = new InformationForm(Resources.multipleViewer128,
                                                                          Hkey.MultipleViewer);
        MdiLayout mdiLayout = MdiLayout.Cascade;
        MdiLayout MdiLay
        {
            set
            {
                mdiLayout = value;
                LayoutMdi(value);
            }
        }
        PictureForm ActiveChild { get { return (PictureForm)ActiveMdiChild; } }

        public MultipleViewerForm()
        {
            InitializeComponent();
            horizontal1.Tag = MdiLayout.TileHorizontal;
            vertical1.Tag = MdiLayout.TileVertical;
            cascade1.Tag = MdiLayout.Cascade;
            arrange1.Tag = MdiLayout.ArrangeIcons;
            zoom2.Tag = zoomAll2.Tag = PictureBoxSizeMode.Zoom;
            stretch2.Tag = stretchAll2.Tag = PictureBoxSizeMode.StretchImage;
            autoSize2.Tag = autoSizeAll2.Tag = PictureBoxSizeMode.AutoSize;
            fswOpen.Filter = Hkey.MultipleViewerOpenDat;
            fswOpen.Path = CommonExtension.AppDataLocalFolder;
        }

        internal void OpenClick(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            bool opened = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                foreach (string name in openFileDialog1.FileNames)
                {
                    var pf = OpenFile(name);
                    if (pf == null) continue;
                    SwitchEnables();
                    opened = true;
                }
            if (!opened) return;
            LayoutMdi(mdiLayout);
            resizeAll2_Click(sender, e);
        }
        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            if (!drgevent.Data.GetDataPresent(DataFormats.FileDrop)) return;
            drgevent.Effect = drgevent.KeyState == 1 ? DragDropEffects.Copy : DragDropEffects.Move;
        }
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            Cursor.Current = Cursors.Default;
            var fileNames = (string[])drgevent.Data.GetData(DataFormats.FileDrop);
            foreach (var n in fileNames) LoadFile(n);
        }
        protected override void OnLoad(EventArgs e)
        {
            RegistryRead();
            BackgroundImage = new Bitmap(Width, Height);
            Layout += MultipleImageViewer_Layout;
            DrawBackground();
            RegistryReadOpening();
            string[] args = Environment.GetCommandLineArgs();
            int n = args.Length;
            if (n > 1) LoadFile(args[1]);
            fswOpen.EnableRaisingEvents = true;
        }
        void LoadFile(string arg)
        {
            if (OpenFile(arg) == null) return;
            SwitchEnables();
            LayoutMdi(mdiLayout);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            RegistryWrite();
        }
        PictureForm OpenFile(string filename)
        {
            PictureForm pf = new PictureForm {SizeMode = PictureBoxSizeMode.Zoom};
            if (!pf.OpenPicture(filename)) return null;
            pf.MdiParent = this;
            window1.Visible = pf.Visible = true;
            return pf;
        }
        void RegistryWrite()
        {
            var data = new Dictionary<string, object>();
            data[Hkey.LocationX] = Left;
            data[Hkey.LocationY] = Top;
            data[Hkey.Width] = Width;
            data[Hkey.Height] = Height;
            data[MdiLayoutMode] = mdiLayout;
            Extension.RegistryWrite(AppRegKey, data);
        }
        void RegistryRead()
        {
            string[] names = { Hkey.LocationX, Hkey.LocationY, Hkey.Width, Hkey.Height, MdiLayoutMode };
            var data = Extension.RegistryRead(AppRegKey, names);
            if (data.ContainsKey(Hkey.LocationX) && data.ContainsKey(Hkey.LocationY))
                Location = new Point((int)data[Hkey.LocationX], (int)data[Hkey.LocationY]);
            if (data.ContainsKey(Hkey.Width)) Width = (int)data[Hkey.Width];
            if (data.ContainsKey(Hkey.Height)) Height = (int)data[Hkey.Height];
            if (!data.ContainsKey(MdiLayoutMode)) return;
            if (!Enum.TryParse(data[MdiLayoutMode].ToString(), out mdiLayout)) mdiLayout = MdiLayout.Cascade;
        }
        void RegistryWriteLocationForColorPicker()
        {
            Point loc = ActiveChild == null ? Location : ActiveChild.PictureLocation,
                pos = loc + (ActiveChild == null ? Size.Divide(2) : ActiveChild.PictureCenter);
            var data = new Dictionary<string, object>();
            data[Hkey.PictureLocationX] = loc.X;
            data[Hkey.PictureLocationY] = loc.Y;
            data[Hkey.PictureCenterX] = pos.X;
            data[Hkey.PictureCenterY] = pos.Y;
            data[Hkey.DirectingPlace] = @"Left";
            Extension.RegistryWrite(Hkey.RootKey + "\\" + Hkey.ColorPicker, data);
        }
        void RegistryReadOpening()
        {
            var data = Extension.RegistryRead(AppOpeningKey, new[] { Hkey.ToDoOpen, Hkey.FileName, Hkey.SizeMode });
            bool flag = data.ContainsKey(Hkey.ToDoOpen) && bool.Parse(data[Hkey.ToDoOpen].ToString());
            if (!flag) return;
            if (!data.ContainsKey(Hkey.FileName)) return;
            string fileName = data[Hkey.FileName].ToString();
            PictureBoxSizeMode sizeMode;
            if (data.ContainsKey(Hkey.SizeMode)) if (Enum.TryParse(data[Hkey.SizeMode].ToString(), out sizeMode)) goto execute;
            sizeMode = PictureBoxSizeMode.Zoom;
        execute:
            ExecuteOpenFile(fileName, sizeMode);
        }
        void ExecuteOpenFile(string fileName, PictureBoxSizeMode sizeMode)
        {
            Extension.RegistryWrite(AppOpeningKey, Hkey.ToDoOpen, false);
            fswOpen.EnableRaisingEvents = false;
            using (var sw = new StreamWriter(MultipleViewerOpenPath)) sw.Write(false);
            bool opened = false;
            PictureForm pf = null;
            foreach (PictureForm child in MdiChildren.Cast<PictureForm>().Where(child => child.FileName == fileName))
            {
                opened = true;
                pf = child;
                break;
            }
            if (!opened)
            {
                pf = OpenFile(fileName);
                if (pf == null) goto END;
                SwitchEnables();
            }
            pf.WindowState = FormWindowState.Maximized;
            pf.SizeMode = sizeMode;
            END: fswOpen.EnableRaisingEvents = true;
        }
        void MultipleImageViewer_Layout(object sender, LayoutEventArgs e)
        {
            DrawBackground();
        }
        void DrawBackground()
        {
            Invalidate();
            using (Graphics gr = Graphics.FromImage(BackgroundImage))
                gr.FillRectangle(new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Gray, Color.DarkGray), ClientRectangle);
        }
        void SwitchEnables()
        {
            zoom2.Enabled = stretch2.Enabled = autoSize2.Enabled = resize2.Enabled = realSize2.Enabled = close2.Enabled = true;
            if (MdiChildren.Length < 1) return;
            zoomAll2.Enabled =
            stretchAll2.Enabled =
            autoSizeAll2.Enabled = resizeAll2.Enabled = realSizeAll2.Enabled = closeAll2.Enabled = true;
            foreach (var child in MdiChildren.Cast<PictureForm>())
                child.zoomAll1.Enabled =
                child.stretchAll1.Enabled =
                child.autoSizeAll1.Enabled =
                child.resizeAll1.Enabled = child.realSizeAll1.Enabled = child.closeAll1.Enabled = true;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void windowItem_Click(object sender, EventArgs e)
        {
            MdiLay = (MdiLayout)((ToolStripItem)sender).Tag;
        }
        private void sizeMode_ButtonClick(object sender, EventArgs e)
        {
            ActiveChild.SizeModeClick(sender, e);
        }
        private void sizeModeAll_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren.Cast<PictureForm>())
                child.SizeModeClick(sender, e);
        }
        private void resize2_ButtonClick(object sender, EventArgs e)
        {
            ActiveChild.Resize1Click(sender, e);
        }
        private void realSize2_ButtonClick(object sender, EventArgs e)
        {
            ActiveChild.RealSize1Click(sender, e);
        }
        private void close2_ButtonClick(object sender, EventArgs e)
        {
            ActiveChild.Close();
        }
        private void resizeAll2_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren.Cast<PictureForm>()) child.Resize1Click(sender, e);
        }
        private void realSizeAll2_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren.Cast<PictureForm>()) child.RealSize1Click(sender, e);
        }
        private void closeAll2_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiChildren) child.Close();
        }
        private void fswOpen_Changed(object sender, FileSystemEventArgs e)
        {
            bool flag;
            using (var sr = new StreamReader(MultipleViewerOpenPath)) flag = bool.Parse(sr.ReadLine() ?? "False");
            if (!flag) return;
            RegistryReadOpening();
        }
        private void MultipleImageViewer_SizeChanged(object sender, EventArgs e)
        {
            LayoutMdi(mdiLayout);
        }
        private void about_Click(object sender, EventArgs e)
        {
            multipleViewerInfo.ShowDialog();
        }
        private void colorMan_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            var processes = Process.GetProcessesByName(Hkey.ColorMan);
            if (processes.Length == 0)
            {
                Cursor = Cursors.AppStarting;
                string executablePath =
                (string)Extension.RegistryRead(Hkey.RootKey + "\\" + Hkey.ColorMan, Hkey.ExecutablePath);
                if (executablePath != null) Process.Start(executablePath);
                Cursor = Cursors.Default;
            }
            else NativeMethods.SetForeground(processes[0].MainWindowHandle);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        private void colorPicker_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            RegistryWriteLocationForColorPicker();
            string executablePath =
            (string)
            Extension.RegistryRead(Hkey.RootKey + "\\" + Hkey.ColorPicker, Hkey.ExecutablePath);
            if (executablePath != null) Process.Start(executablePath);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        private void compactViewer_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            if (ActiveChild != null)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();
                data[Hkey.ToDoOpen] = true;
                data[Hkey.FileName] = ActiveChild.FileName;
                data[Hkey.SizeMode] = ActiveChild.SizeMode;
                Extension.RegistryWrite(Hkey.RootKey + "\\" + Hkey.CompactViewer + "\\" + Hkey.Opening, data);
                string dir =
                (string)Extension.RegistryRead(Hkey.RootKey + "\\" + Hkey.CompactViewer, Hkey.AppDataLocalFolder);
                if (dir != null) using (var sw = new StreamWriter(dir + "\\" + Hkey.CompactViewerOpenDat)) sw.Write(true);
            }
            var processes = Process.GetProcessesByName(Hkey.CompactViewer);
            if (processes.Length == 0)
            {
                string executablePath =
                (string)Extension.RegistryRead(Hkey.RootKey + "\\" + Hkey.CompactViewer, Hkey.ExecutablePath);
                if (executablePath != null) Process.Start(executablePath);
            }
            else NativeMethods.SetForeground(processes[0].MainWindowHandle);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        private void explorer_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            if (ActiveChild == null) Process.Start("explorer.exe");
            else Process.Start("explorer.exe", "/select," + ActiveChild.FileName);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        private void snipping_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            Process.Start("SnippingTool.exe");
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ColorMan.CompactViewer.Properties;
using ColorMan.ExtensionLibrary;
using ColorMan.FormLibrary;
using CommonExtension = ColorMan.ExtensionLibrary.Extension;

[assembly: CLSCompliant(true)]
namespace ColorMan.CompactViewer
{
    public partial class CompactViewerForm : Form
    {
        public const string AppRegKey = Hkey.RootKey + "\\" + Hkey.CompactViewer;
        const string Title = "Compact Image Viewer", AppOpeningKey = AppRegKey + "\\" + Hkey.Opening,
                     Distance1 = "SplitterDistance1", Distance2 = "SplitterDistance2", WorkingFolder = "WorkingFolder";
        static readonly string CompactViewerOpenPath = CommonExtension.AppDataLocalFolder + "\\" + Hkey.CompactViewerOpenDat;

        readonly ImageFileMessageBox deleteMessage =
        new ImageFileMessageBox("Вы действительно хотите безвозвратно удалить этот файл?", "Удалить файл",
                                Resources.delete_file);
        readonly InformationForm compactViewerInfo = new InformationForm(Resources.compactViewer128, Hkey.CompactViewer);
        Cursor fileCursor;
        IList names;
        bool inner, invalidFile;
        int keyState = 1;

        string FileName { get { return fileListBox1.FileName; } }
        Size PictureCenter { get { return splitContainer2.Panel2.Size.Divide(2); } }
        int FilesCount { get { return fileListBox1.Items.Count; } }
        string FullPath
        {
            get { return fileListBox1.Path + (FilesCount > 0 ? Path.DirectorySeparatorChar + FileName : string.Empty); }
        }

        public CompactViewerForm()
        {
            InitializeComponent();
            fswOpen.Filter = Hkey.CompactViewerOpenDat;
            fswOpen.Path = CommonExtension.AppDataLocalFolder;
        }

        protected override void OnLoad(EventArgs e)
        {
            dirListBox1_Change(null, null);
            RegistryRead();
            RegistryReadOpening();
            checkBox1_CheckStateChanged(this, e);
            SelectCurrentFile();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 1) return;
            textBox1.Text = args[1];
            btnGo_Click(null, null);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            RegistryWrite();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.Delete:
                case Keys.Shift | Keys.Delete:
                case Keys.Delete:
                    delete1_Click(null, null);
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            gfbevent.UseDefaultCursors = false;
            Cursor.Current = fileCursor;
        }
        protected override void OnDragOver(DragEventArgs drgevent)
        {
            Cursor.Current = fileCursor;
        }
        Cursor CreateCursor(string path)
        {
            const int N = 48;
            using (var image = Image.FromFile(path))
            {
                double multiplier = (double)N / Math.Max(image.Width, image.Height);
                Size t = image.Size.Multiply(multiplier);
                if (fileCursor != null) fileCursor.Dispose();
                fileCursor = new Cursor(new Bitmap(image, t).GetHicon());
            }
            return fileCursor;
        }
        void RegistryWrite()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data[Hkey.Width] = Width;
            data[Hkey.Height] = Height;
            data[Hkey.LocationX] = Left;
            data[Hkey.LocationY] = Top;
            data[Hkey.SizeMode] = checkBox1.CheckState;
            data[Distance1] = splitContainer1.SplitterDistance;
            data[Distance2] = splitContainer2.SplitterDistance;
            CommonExtension.RegistryWrite(AppRegKey, data);
        }
        void RegistryRead()
        {
            string[] keys = { Hkey.Width, Hkey.Height, Hkey.LocationX, Hkey.LocationY, Hkey.SizeMode, Distance1, Distance2, WorkingFolder };
            var data = CommonExtension.RegistryRead(AppRegKey, keys);
            if (data.ContainsKey(Hkey.Width)) Width = (int)data[Hkey.Width];
            if (data.ContainsKey(Hkey.Height)) Height = (int)data[Hkey.Height];
            if (data.ContainsKey(Hkey.LocationX)) Left = (int)data[Hkey.LocationX];
            if (data.ContainsKey(Hkey.LocationY)) Top = (int)data[Hkey.LocationY];
            CheckState checkState;
            if (data.ContainsKey(Hkey.SizeMode) && Enum.TryParse(data[Hkey.SizeMode].ToString(), out checkState))
                checkBox1.CheckState = checkState;
            if (data.ContainsKey(Distance1)) splitContainer1.SplitterDistance = (int)data[Distance1];
            if (data.ContainsKey(Distance2)) splitContainer2.SplitterDistance = (int)data[Distance2];
            if (data.ContainsKey(WorkingFolder)) SetWorkingFolder(data[WorkingFolder].ToString());
        }
        void RegistryReadOpening()
        {
            var data = CommonExtension.RegistryRead(AppOpeningKey, new[] { Hkey.ToDoOpen, Hkey.FileName, Hkey.SizeMode });
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
        void RegistryWriteLocationForColorPicker()
        {
            Point loc = pictureControl1.ScreenLocation(), pos = loc + PictureCenter;
            var data = new Dictionary<string, object>();
            data[Hkey.PictureLocationX] = loc.X;
            data[Hkey.PictureLocationY] = loc.Y;
            data[Hkey.PictureCenterX] = pos.X;
            data[Hkey.PictureCenterY] = pos.Y;
            data[Hkey.DirectingPlace] = @"Left";
            CommonExtension.RegistryWrite(Hkey.RootKey + "\\" + Hkey.ColorPicker, data);
        }
        void ExecuteOpenFile(string fileName, PictureBoxSizeMode sizeMode)
        {
            CommonExtension.RegistryWrite(AppOpeningKey, Hkey.ToDoOpen, false);
            fswOpen.EnableRaisingEvents = false;
            using (var sw = new StreamWriter(CompactViewerOpenPath)) sw.Write(false);
            textBox1.Text = fileName;
            btnGo_Click(null, null);
            pictureControl1.SizeMode = sizeMode;
            fswOpen.EnableRaisingEvents = true;
        }
        void SetWorkingFolder(string path)
        {
            driveListBox1.Drive = Path.GetPathRoot(path);
            dirListBox1.Path = path;
            dirListBox1_Change(this, null);
        }
        void ClearFile()
        {
            pictureControl1.Clear();
            pictureControl1.SetFileName(string.Empty);
            Text = Title;
            textBox1.Text = fileListBox1.Path;
        }
        void SelectCurrentFile()
        {
            try
            {
                pictureControl1.SetFileName(textBox1.Text = FullPath);
                Image image = new Bitmap(FullPath);
                pictureControl1.Picture = image;
                Text = string.Format(CultureInfo.InvariantCulture, @"{3} - {0} ({1}x{2})", FileName, image.Width,
                                     image.Height, Title);
                invalidFile = false;
            }
            catch 
            {
                invalidFile = true;
                ClearFile();
            }
        }
        void PasteFile(string fullpath)
        {
            if (string.Equals(Path.GetFileName(fullpath), fileListBox1.FileName, StringComparison.OrdinalIgnoreCase))
            {
                ClearFile();
                Paste(fullpath);
                SelectCurrentFile();
            }
            else
            {
                string ext = Path.GetExtension(fullpath);
                if (ext == null || !fileListBox1.Pattern.Contains(ext)) return;
                Paste(fullpath);
                var item = fileListBox1.SelectedItem;
                fileListBox1.Refresh();
                fileListBox1.SelectedItem = item;
            }
        }
        void Paste(string fullpath)
        {
            string name = Path.GetFileName(fullpath);
            switch (keyState)
            {
                case 1:
                    string destinationPath = fileListBox1.Path + Path.DirectorySeparatorChar + name;
                    if (!Path.Equals(fullpath, destinationPath))
                        File.Copy(fullpath, fileListBox1.Path + Path.DirectorySeparatorChar + name);
                    break;
                case 5:
                    File.Move(fullpath, fileListBox1.Path + Path.DirectorySeparatorChar + name);
                    keyState = 1;
                    break;
            }
        }
        void RefreshFiles(int i)
        {
            fileListBox1.Refresh();
            int count = FilesCount;
            if (count > 0) fileListBox1.SelectedIndex = i < 0 ? 0 : i > count - 1 ? count - 1 : i;
        }
        void UpdateFileSystem()
        {
            driveListBox1.Refresh();
            dirListBox1.Refresh();
            RefreshFiles(fileListBox1.SelectedIndex);
        }
        void SelectFile(string path)
        {
            driveListBox1.Drive = path[0] + ":";
            dirListBox1.Path = Path.GetDirectoryName(path);
            string name = Path.GetFileName(path);
            fileListBox1.SelectedIndex = fileListBox1.Items.IndexOf(name);
        }
        void colorPicker_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            RegistryWriteLocationForColorPicker();
            string executablePath =
            (string)
            CommonExtension.RegistryRead(Hkey.RootKey + "\\" + Hkey.ColorPicker, Hkey.ExecutablePath);
            if (executablePath != null) Process.Start(executablePath);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        void colorMan_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            var processes = Process.GetProcessesByName(Hkey.ColorMan);
            if (processes.Length == 0)
            {
                string executablePath =
                (string)
                CommonExtension.RegistryRead(Hkey.RootKey + "\\" + Hkey.ColorMan, Hkey.ExecutablePath);
                if (executablePath != null) 
                    Process.Start(executablePath);
            }
            else NativeMethods.SetForeground(processes[0].MainWindowHandle);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        void multipleViewer_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            if (FilesCount > 0)
            {
                const string RegistryBranch = Hkey.RootKey + "\\" + Hkey.MultipleViewer + "\\" + Hkey.Opening;
                Dictionary<string, object> data = new Dictionary<string, object>();
                data[Hkey.ToDoOpen] = true;
                data[Hkey.FileName] = textBox1.Text;
                data[Hkey.SizeMode] = pictureControl1.SizeMode;
                CommonExtension.RegistryWrite(RegistryBranch, data);
                string dir =
                (string)CommonExtension.RegistryRead(Hkey.RootKey + "\\" + Hkey.MultipleViewer, Hkey.AppDataLocalFolder);
                if (dir != null) using (var sw = new StreamWriter(dir + "\\" + Hkey.MultipleViewerOpenDat)) sw.Write(true);
            }
            var processes = Process.GetProcessesByName(Hkey.MultipleViewer);
            if (processes.Length == 0)
            {
                string executablePath =
                (string)
                CommonExtension.RegistryRead(Hkey.RootKey + "\\" + Hkey.MultipleViewer, Hkey.ExecutablePath);
                if (executablePath != null) Process.Start(executablePath);
            }
            else NativeMethods.SetForeground(processes[0].MainWindowHandle);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        void exit11_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dirListBox1_Change(object sender, EventArgs e)
        {
            fileSystemWatcher1.Path = textBox1.Text = fileListBox1.Path = dirListBox1.Path;
            if (FilesCount > 0) fileListBox1.SelectedIndex = 0;
            else ClearFile();
        }
        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCurrentFile();
        }
        private void dirListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') dirListBox1.Path = dirListBox1.get_DirList(dirListBox1.DirListIndex);
        }
        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (!new DriveInfo(driveListBox1.Drive).IsReady)
                if (
                MessageBox.Show(string.Format(CultureInfo.InvariantCulture, @"Drive {0} is not ready.", driveListBox1.Drive),
                @"Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly) != DialogResult.Retry)
                {
                    driveListBox1.SelectedIndexChanged -= driveListBox1_SelectedIndexChanged;
                    driveListBox1.Drive = dirListBox1.Path[0] + ":";
                    driveListBox1.SelectedIndexChanged += driveListBox1_SelectedIndexChanged;
                    Activate();
                    return;
                }
            dirListBox1.Path = driveListBox1.Drive[0] + ":\\";
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            const string SM = "&Size mode: ";
            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    pictureControl1.SizeMode = PictureBoxSizeMode.Zoom;
                    checkBox1.Text = SM + @" Zoom";
                    lbSM.Image = Resources.zoomMode;
                    break;
                case CheckState.Indeterminate:
                    pictureControl1.SizeMode = PictureBoxSizeMode.StretchImage;
                    checkBox1.Text = SM + @" Stretch";
                    lbSM.Image = Resources.stretchMode;
                    break;
                case CheckState.Unchecked:
                    pictureControl1.SizeMode = PictureBoxSizeMode.AutoSize;
                    checkBox1.Text = SM + @" AutoSize";
                    lbSM.Image = Resources.autoSizeMode;
                    break;
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (File.Exists(path)) SelectFile(path);
            else if (Directory.Exists(path))
                try
                {
                    driveListBox1.Drive = path[0] + ":";
                    dirListBox1.Path = path;
                }
                catch
                {
                    ShowErrorMessage(path);
                }
            else ShowErrorMessage(path);
        }

        void ShowErrorMessage(string path)
        {
            MessageBox.Show(string.Format(CultureInfo.InvariantCulture, @"Path {0} is wrong.", path), @"Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
            Activate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnGo_Click(sender, e);
            e.SuppressKeyPress = true;
        }
        private void copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetFileDropList(new StringCollection { FullPath });
        }
        private void paste1_Click(object sender, EventArgs e)
        {
            names = Clipboard.GetFileDropList();
            foreach (string fp in names) PasteFile(fp);
            names = null;
        }
        private void delete1_Click(object sender, EventArgs e)
        {
            if (fileCursor != null) fileCursor.Dispose();
            Keys mod = Keys.Modifiers & ModifierKeys;
            string fp = FullPath;
            int i = fileListBox1.SelectedIndex;
            if (mod == Keys.Shift)
            {
                deleteMessage.SetImageFile(fp);
                if (deleteMessage.ShowDialog() == DialogResult.No) return;
                ClearFile();
                File.Delete(fp);
                RefreshFiles(i);
            }
            else
            {
                ClearFile();
                if (mod == Keys.Control) File.Delete(fp);
                else CommonExtension.RecycleFile(fp);
                RefreshFiles(i);
            }
        }
        private void cms_Files_Opening(object sender, CancelEventArgs e)
        {
            paste1.Enabled = Clipboard.ContainsFileDropList();
            copy1.Enabled = delete1.Enabled = FilesCount > 0;
        }
        private void explorer_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            Process.Start("explorer.exe", "/select," + textBox1.Text);
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
        private void fileListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            SelectCurrentFile();
            if (invalidFile) return;
            Cursor.Current = CreateCursor(FullPath);
            inner = true;
            DoDragDrop(new DataObject(DataFormats.FileDrop, new[] { FullPath }), DragDropEffects.Copy);
            inner = false;
        }
        private void fileListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
        private void control_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            keyState = e.KeyState;
            e.Effect = keyState == 1 ? DragDropEffects.Copy : DragDropEffects.Move;
            names = (string[])e.Data.GetData(DataFormats.FileDrop);
        }
        private void control_DragDrop(object sender, DragEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            if (inner)
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            foreach (string fp in names) PasteFile(fp);
            names = null;
        }
        private void fileSystemWatcher1_Events(object sender, FileSystemEventArgs e)
        {
            UpdateFileSystem();
        }
        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            UpdateFileSystem();
        }
        private void workingDirectory1_Click(object sender, EventArgs e)
        {
            object obj = CommonExtension.RegistryRead(AppRegKey, WorkingFolder);
            if (obj != null) folderBrowserDialog1.SelectedPath = obj.ToString();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                CommonExtension.RegistryWrite(AppRegKey, WorkingFolder, folderBrowserDialog1.SelectedPath);
        }
        private void about_Click(object sender, EventArgs e)
        {
            compactViewerInfo.ShowDialog();
        }
        private void fswOpen_Changed(object sender, FileSystemEventArgs e)
        {
            bool flag;
            using (var sr = new StreamReader(CompactViewerOpenPath)) flag = bool.Parse(sr.ReadLine() ?? "False");
            if (!flag) return;
            RegistryReadOpening();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ColorMan.ExtensionLibrary;

namespace ColorMan.MultipleViewer
{
    public partial class PictureForm : Form
    {
        Image original;
        Point start, move1, move2, mouseStart, mouseEnd;
        Size selectionSize;
        bool downed, rightDowned;
        readonly Cursor moveCur, overCur, crossCur;

        MultipleViewerForm ParentViewer { get { return MdiParent as MultipleViewerForm; } }
        IEnumerable<PictureForm> Children
        {
            get { return from child in MdiParent.MdiChildren select child as PictureForm; }
        }
        Image Picture
        {
            get { return pictureBox1.Image; }
            set
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                if (SizeMode != PictureBoxSizeMode.AutoSize) Pbd = DockStyle.Fill;
                pictureBox1.Image = original = value;
                if (value == null)
                {
                    Pbs = ClientSize;
                    Cursor = Cursors.Default;
                }
                else if (SizeMode == PictureBoxSizeMode.AutoSize) ScrollToCenter();
            }
        }
        public PictureBoxSizeMode SizeMode
        {
            get { return pictureBox1.SizeMode; }
            set { pictureBox1.SizeMode = value; }
        }
        public Point PictureLocation { get { return pictureBox1.ScreenLocation(); } }
        public Size PictureCenter { get { return Pbs.Divide(2); } }
        public string FileName { get; private set; }
        Point Pbl { get { return pictureBox1.Location; } set { pictureBox1.Location = value; } }
        Size Pbs { get { return pictureBox1.Size; } set { pictureBox1.Size = value; } }
        int Pbw { get { return pictureBox1.Width; } set { pictureBox1.Width = value; } }
        int Pbh { get { return pictureBox1.Height; } set { pictureBox1.Height = value; } }
        DockStyle Pbd { get { return pictureBox1.Dock; } set { pictureBox1.Dock = value; } }

        public PictureForm(Form mdiParent) : this()
        {
            MdiParent = mdiParent;
        }
        public PictureForm()
        {
            InitializeComponent();
            zoom1.Tag = zoomAll1.Tag = PictureBoxSizeMode.Zoom;
            stretch1.Tag = stretchAll1.Tag = PictureBoxSizeMode.StretchImage;
            autoSize1.Tag = autoSizeAll1.Tag = PictureBoxSizeMode.AutoSize;
            moveCur = new Cursor(GetType(), "HandMove.cur");
            overCur = new Cursor(GetType(), "HandOver.cur");
            crossCur = new Cursor(GetType(), "SelectionCross.cur");
        }

        internal bool OpenPicture(string filename)
        {
            try
            {
                Picture = Image.FromFile(filename);
            }
            catch
            {
                return false;
            }
            FileName = filename;
            Text = string.Format(CultureInfo.InvariantCulture,
                @"{0} ({1}x{2})", Path.GetFileNameWithoutExtension(filename), Picture.Width, Picture.Height);
            return true;
        }
        internal void SizeModeClick(object sender, EventArgs e)
        {
            SizeMode = (PictureBoxSizeMode)((ToolStripItem)sender).Tag;
        }
        internal void Resize1Click(object sender, EventArgs e)
        {
            switch (SizeMode)
            {
                case PictureBoxSizeMode.StretchImage:
                    SizeMode = PictureBoxSizeMode.Zoom;
                    ZoomResize();
                    break;
                case PictureBoxSizeMode.AutoSize:
                    AutoResize();
                    break;
                case PictureBoxSizeMode.Zoom:
                    ZoomResize();
                    break;
            }
        }
        internal void RealSize1Click(object sender, EventArgs e)
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
            ClientSize = original.Size;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            int len = MdiParent.MdiChildren.Length;
            if (len == 1)
                ParentViewer.window1.Visible =
                ParentViewer.zoom2.Enabled =
                ParentViewer.stretch2.Enabled =
                ParentViewer.autoSize2.Enabled =
                ParentViewer.resize2.Enabled = ParentViewer.realSize2.Enabled = ParentViewer.close2.Enabled = false;
            else if (len == 2)
            {
                ParentViewer.closeAll2.Enabled =
                ParentViewer.zoomAll2.Enabled =
                ParentViewer.stretchAll2.Enabled =
                ParentViewer.autoSizeAll2.Enabled =
                ParentViewer.resizeAll2.Enabled = ParentViewer.realSizeAll2.Enabled = false;
                foreach (var child in Children)
                    if (child != this)
                        child.zoomAll1.Enabled =
                        child.stretchAll1.Enabled =
                        child.autoSizeAll1.Enabled =
                        child.resizeAll1.Enabled = child.realSizeAll1.Enabled = child.closeAll1.Enabled = false;
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Modifiers != Keys.Alt) return;
            if (SizeMode == PictureBoxSizeMode.AutoSize) ScrollKeyDown(e);
            if (SizeMode == PictureBoxSizeMode.Zoom) ZoomKeyDown(e);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            switch (SizeMode)
            {
                case PictureBoxSizeMode.Zoom:
                    if (e.Delta > 0 && ClientSize == Pbs) ScalingOn();
                    ScalePicture(e);
                    break;
                case PictureBoxSizeMode.AutoSize:
                    ScrollPicture(e);
                    break;
            }
        }
        Size GetDisplayPictureSize()
        {
            double kx = (double)original.Width / ClientSize.Width, ky = (double)original.Height / ClientSize.Height;
            return original.Size.Divide(Math.Max(kx, ky));
        }
        Image CreateSelectionImage()
        {
            Image im = selectionSize.NewBitmap();
            using (Graphics gr = Graphics.FromImage(im))
                gr.CopyFromScreen(new Point(Math.Min(mouseStart.X, mouseEnd.X), Math.Min(mouseStart.Y, mouseEnd.Y)),
                                  Point.Empty, selectionSize);
            return im;
        }
        void ScrollToCenter()
        {
            int width = ClientSize.Width, height = ClientSize.Height;
            AutoScrollPosition = new Point((Pbw - width) / 2, (Pbh - height) / 2);
        }
        void ScalingOn()
        {
            AutoScroll = false;
            Pbd = DockStyle.None;
            Pbs = GetDisplayPictureSize();
            pictureBox1.AlignByCenter();
        }
        void ScalePicture(MouseEventArgs e)
        {
            Point l = e.Location;
            double k = 1.0 + e.Delta / 2400.0;
            ScalePicture(k, l);
        }
        void ScalePicture(double k, Point l)
        {
            Size size = Pbs.Multiply(k), maximumSize = pictureBox1.MaximumSize;
            int w = size.Width, h = size.Height;
            if (w > maximumSize.Width || h > maximumSize.Height) return;
            if (w < ClientSize.Width && h < ClientSize.Height)
            {
                pictureBox1.AlignByCenter();
                Cursor = Cursors.Default;
                Pbd = DockStyle.Fill;
                return;
            }
            Pbs = size;
            Point d = l - new Size(Pbl);
            Size s1 = new Size(d), s2 = s1.Multiply(k), ds = s2 - s1;
            Pbl -= ds;
            Cursor = overCur;
        }
        void ScrollPicture(MouseEventArgs e)
        {
            int x = AutoScrollPosition.X, y = AutoScrollPosition.Y, d = e.Delta;
            AutoScrollPosition = ModifierKeys == Keys.Shift ? new Point(-x - d, -y) : new Point(-x, -y - d);
        }
        void ZoomResize()
        {
            ClientSize = GetDisplayPictureSize();
            Pbd = DockStyle.Fill;
        }
        void AutoResize()
        {
            int cw = ClientSize.Width, ch = ClientSize.Height, ow = original.Width, oh = original.Height,
                w = cw > ow ? Width - cw + ow : Width, h = ch > oh ? Height - ch + oh : Height;
            Size = new Size(w, h);
        }
        void ScrollKeyDown(KeyEventArgs e)
        {
            Size sx = new Size(10, 0), sy = new Size(0, 10);
            Point p = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
            int width = ClientSize.Width, height = ClientSize.Height;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    p -= sy;
                    break;
                case Keys.Down:
                    p += sy;
                    break;
                case Keys.Left:
                    p -= sx;
                    break;
                case Keys.Right:
                    p += sx;
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                case Keys.Home:
                    p = Point.Empty;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                case Keys.PageDown:
                    p = new Point(Pbs);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                case Keys.End:
                    p = new Point(0, Pbh);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                case Keys.PageUp:
                    p = new Point(Pbw);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    p = new Point((Pbw - width) / 2, (Pbh - height) / 2);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    p = new Point(0, (Pbh - height) / 2);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    p = new Point((Pbw - width) / 2);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    p = new Point(Pbw, (Pbh - height) / 2);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    p = new Point((Pbw - width) / 2, Pbh);
                    break;
            }
            AutoScrollPosition = p;
        }
        void ZoomKeyDown(KeyEventArgs e)
        {
            Size sx = new Size(10, 0), sy = new Size(0, 10);
            Point p = Pbl;
            int minX = -Pbw + ClientSize.Width, minY = -Pbh + ClientSize.Height;
            double delta;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    p += sy;
                    CutRangePbl(p);
                    break;
                case Keys.Down:
                    p -= sy;
                    CutRangePbl(p);
                    break;
                case Keys.Left:
                    p += sx;
                    CutRangePbl(p);
                    break;
                case Keys.Right:
                    p -= sx;
                    CutRangePbl(p);
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                case Keys.Home:
                    Pbl = Point.Empty;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                case Keys.PageDown:
                    Pbl = new Point(minX, minY);
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                case Keys.End:
                    Pbl = new Point(0, minY);
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                case Keys.PageUp:
                    Pbl = new Point(minX);
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    Pbl = new Point(minX / 2, minY / 2);
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    Pbl = new Point(0, minY / 2);
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    Pbl = new Point(minX / 2);
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    Pbl = new Point(minX, minY / 2);
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    Pbl = new Point(minX / 2, minY);
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    delta = 1.01;
                    if (Size == Pbs) ScalingOn();
                    ScalePicture(delta, new Point(ClientSize.Divide(2)));
                    e.SuppressKeyPress = true;
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    delta = 0.99;
                    ScalePicture(delta, new Point(ClientSize.Divide(2)));
                    e.SuppressKeyPress = true;
                    break;
            }
        }
        void CutRangePbl(Point p)
        {
            Pbl = new Point(p.X.CutRange(ClientSize.Width - Pbw, 0), p.Y.CutRange(ClientSize.Height - Pbh, 0));
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            mouseStart = MousePosition;
            if (e.Button == MouseButtons.Left)
            {
                downed = true;
                if (SizeMode == PictureBoxSizeMode.AutoSize || (SizeMode == PictureBoxSizeMode.Zoom && Size != Pbs))
                    Cursor = moveCur;
            }
            else if (e.Button == MouseButtons.Right)
            {
                rightDowned = true;
                if (Picture != null) Cursor = crossCur;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (downed)
            {
                move1 = e.Location - new Size(start);
                if (SizeMode == PictureBoxSizeMode.AutoSize) AutoScrollPosition =
                    new Point(-AutoScrollPosition.X - move1.X, -AutoScrollPosition.Y - move1.Y);
                else
                {
                    int dw = ClientSize.Width - Pbw, dh = ClientSize.Height - Pbh;
                    Pbl = new Point(dw > 0 ? dw / 2 : (Pbl.X + move1.X).CutRange(dw, 0),
                                    dh > 0 ? dh / 2 : (Pbl.Y + move1.Y).CutRange(dh, 0));
                }
            }
            else if (rightDowned)
            {
                Size d = new Size(1, 1);
                Point p = mouseStart - d;
                ControlPaint.DrawReversibleFrame(new Rectangle(p, new Size(move2) + d), Color.Black, FrameStyle.Dashed);
                move2 = MousePosition - new Size(mouseStart);
                ControlPaint.DrawReversibleFrame(new Rectangle(p, new Size(move2) + d), Color.Black, FrameStyle.Dashed);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            downed = rightDowned = false;
            mouseEnd = MousePosition;
            selectionSize = new Size(Math.Abs(move2.X - 1), Math.Abs(move2.Y - 1));
            move2 = Point.Empty;
            Cursor = SizeMode == PictureBoxSizeMode.AutoSize || (SizeMode == PictureBoxSizeMode.Zoom && Size != Pbs) ?
                overCur : Cursors.Default;
            Focus();
            if (e.Button == MouseButtons.Right)
                cms_pc.Show(Math.Min(mouseStart.X, mouseEnd.X), Math.Max(mouseStart.Y, mouseEnd.Y));
        }
        private void pictureBox1_SizeModeChanged(object sender, EventArgs e)
        {
            switch (SizeMode)
            {
                case PictureBoxSizeMode.Normal:
                    Pbd = DockStyle.Fill;
                    break;
                case PictureBoxSizeMode.StretchImage:
                    Pbd = DockStyle.Fill;
                    break;
                case PictureBoxSizeMode.AutoSize:
                    Pbd = DockStyle.None;
                    AutoScroll = true;
                    Pbl = Point.Empty;
                    ScrollToCenter();
                    break;
                case PictureBoxSizeMode.CenterImage:
                    Pbd = DockStyle.Fill;
                    break;
                case PictureBoxSizeMode.Zoom:
                    Pbd = DockStyle.Fill;
                    break;
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = (Pbw > ClientSize.Width || Pbh > ClientSize.Height) &&
            (SizeMode == PictureBoxSizeMode.AutoSize || SizeMode == PictureBoxSizeMode.Zoom) ? overCur : Cursors.Default;
        }
        private void open1_Click(object sender, EventArgs e)
        {
            ParentViewer.OpenClick(this, null);
        }
        private void close1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void exit1_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
        }
        private void closeAll1_Click(object sender, EventArgs e)
        {
            foreach (var child in MdiParent.MdiChildren) child.Close();
        }
        private void sizeModeAll_Click(object sender, EventArgs e)
        {
            foreach (var child in Children) child.SizeMode = (PictureBoxSizeMode)((ToolStripItem)sender).Tag;
        }
        private void resizeAll1_Click(object sender, EventArgs e)
        {
            foreach (var child in Children) child.Resize1Click(this, e);
        }
        private void realSizeAll1_Click(object sender, EventArgs e)
        {
            foreach (var child in Children) child.RealSize1Click(this, e);
        }
        private void copy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(CreateSelectionImage());
        }
        private void save1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.GetNextFileName("image");
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            CreateSelectionImage().Save(saveFileDialog1.FileName);
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(saveFileDialog1.FileName);
        }
        private void cms_pc_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = Picture == null || move2 == Point.Empty;
        }
    }
}

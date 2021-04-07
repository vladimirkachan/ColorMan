using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ColorMan.ExtensionLibrary;

namespace ColorMan.ControlsLibrary
{
    public partial class PictureControl : UserControl
    {
        Form form;
        Image original;
        Point start, move1, move2, mouseStart, mouseEnd;
        Size selectionSize;
        bool downed, rightDowned;
        readonly Cursor moveCur, overCur, crossCur;

        public Image Picture
        {
            get { return pictureBox1.Image; }
            set
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                if (SizeMode != PictureBoxSizeMode.AutoSize) SetPbd(DockStyle.Fill);
                pictureBox1.Image = original = value;
                if (value == null)
                {
                    Pbs = Size;
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
        Point Pbl { get { return pictureBox1.Location; } set { pictureBox1.Location = value; } }
        Size Pbs { get { return pictureBox1.Size; } set { pictureBox1.Size = value; } }
        int Pbw { get { return pictureBox1.Width; } }
        int Pbh { get { return pictureBox1.Height; } }
        void SetPbd(DockStyle value)
        {
            pictureBox1.Dock = value;
        }

        public PictureControl()
        {
            InitializeComponent();
            moveCur = new Cursor(GetType(), "HandMove.cur");
            overCur = new Cursor(GetType(), "HandOver.cur");
            crossCur = new Cursor(GetType(), "SelectionCross.cur");
        }

        public void SetFileName(string name)
        {
            saveFileDialog1.FileName = name;
            if (string.IsNullOrWhiteSpace(name)) saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            else
                try
                {
                    saveFileDialog1.InitialDirectory = Path.GetDirectoryName(name);
                }
                catch
                {
                    saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                }
        }
        public void Clear()
            {
                if (Picture != null) Picture.Dispose();
                Picture = null;
            }
            void ScrollToCenter()
            {
                AutoScrollPosition = new Point((Pbw - Width) / 2, (Pbh - Height) / 2);
            }
            void ScalingOn()
            {
                AutoScroll = false;
                SetPbd(DockStyle.None);
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
                if (w < Width && h < Height)
                {
                    pictureBox1.AlignByCenter();
                    Cursor = Cursors.Default;
                    SetPbd(DockStyle.Fill);
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
            Size GetDisplayPictureSize()
            {
                double kx = (double)original.Width / Width, ky = (double)original.Height / Height;
                return original.Size.Divide(Math.Max(kx, ky));
            }
            void form_Layout(object sender, LayoutEventArgs e)
            {
                if (form.WindowState == FormWindowState.Maximized && SizeMode == PictureBoxSizeMode.Zoom)
                {
                    Size = form.ClientSize;
                    Pbs = Size;
                    pictureBox1.AlignByCenter();
                }
            }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Modifiers != Keys.Alt) return;
            if (SizeMode == PictureBoxSizeMode.AutoSize) ScrollKeyDown(e);
            if (SizeMode == PictureBoxSizeMode.Zoom) ZoomKeyDown(e);
        }
        void ScrollKeyDown(KeyEventArgs e)
        {
            Size sx = new Size(10, 0), sy = new Size(0, 10);
            Point p = new Point(-AutoScrollPosition.X, -AutoScrollPosition.Y);
            switch (e.KeyCode)
            {
                case Keys.Up: p -= sy; break;
                case Keys.Down: p += sy; break;
                case Keys.Left: p -= sx; break;
                case Keys.Right: p += sx; break;
                case Keys.D7:
                case Keys.NumPad7:
                case Keys.Home: p = Point.Empty; break;
                case Keys.D3:
                case Keys.NumPad3:
                case Keys.PageDown: p = new Point(Pbs); break;
                case Keys.D1:
                case Keys.NumPad1:
                case Keys.End: p = new Point(0, Pbh); break;
                case Keys.D9:
                case Keys.NumPad9:
                case Keys.PageUp: p = new Point(Pbw); break;
                case Keys.D5:
                case Keys.NumPad5: p = new Point((Pbw - Width) / 2, (Pbh - Height) / 2); break;
                case Keys.D4:
                case Keys.NumPad4: p = new Point(0, (Pbh - Height) / 2); break;
                case Keys.D8:
                case Keys.NumPad8: p = new Point((Pbw - Width) / 2); break;
                case Keys.D6:
                case Keys.NumPad6: p = new Point(Pbw, (Pbh - Height) / 2); break;
                case Keys.D2:
                case Keys.NumPad2: p = new Point((Pbw - Width) / 2, Pbh); break;
            }
            AutoScrollPosition = p;
        }
        void ZoomKeyDown(KeyEventArgs e)
        {
            Size sx = new Size(10, 0), sy = new Size(0, 10);
            Point p = Pbl;
            int minX = -Pbw + Width, minY = -Pbh + Height;
            double delta;
            switch (e.KeyCode)
            {
                case Keys.Up: p += sy; CutRangePbl(p); break;
                case Keys.Down: p -= sy; CutRangePbl(p); break;
                case Keys.Left: p += sx; CutRangePbl(p); break;
                case Keys.Right: p -= sx; CutRangePbl(p); break;
                case Keys.D7:
                case Keys.NumPad7:
                case Keys.Home: Pbl = Point.Empty; break;
                case Keys.D3:
                case Keys.NumPad3:
                case Keys.PageDown: Pbl = new Point(minX, minY); break;
                case Keys.D1:
                case Keys.NumPad1:
                case Keys.End: Pbl = new Point(0, minY); break;
                case Keys.D9:
                case Keys.NumPad9:
                case Keys.PageUp: Pbl = new Point(minX); break;
                case Keys.D5:
                case Keys.NumPad5: Pbl = new Point(minX / 2, minY / 2); break;
                case Keys.D4:
                case Keys.NumPad4: Pbl = new Point(0, minY / 2); break;
                case Keys.D8:
                case Keys.NumPad8: Pbl = new Point(minX / 2); break;
                case Keys.D6:
                case Keys.NumPad6: Pbl = new Point(minX, minY / 2); break;
                case Keys.D2:
                case Keys.NumPad2: Pbl = new Point(minX / 2, minY); break;
                case Keys.Oemplus:
                case Keys.Add:
                    delta = 1.01; if (Size == Pbs) ScalingOn(); ScalePicture(delta, new Point(Size.Divide(2)));
                    e.SuppressKeyPress = true; break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    delta = 0.99; ScalePicture(delta, new Point(Size.Divide(2)));
                    e.SuppressKeyPress = true; break;
            }
        }
        void CutRangePbl(Point p)
        {
            Pbl = new Point(p.X.CutRange(Width - Pbw, 0), p.Y.CutRange(Height - Pbh, 0));
        }
        protected override void OnLoad(EventArgs e)
        {
            Pbs = Size;
            Pbl = Point.Empty;
            form = FindForm();
            if (form != null) form.Layout += form_Layout;
            base.OnLoad(e);
        }
        protected override void OnLayout(LayoutEventArgs e)
        {
            if (SizeMode == PictureBoxSizeMode.Zoom)
            {
                int dw = Width - Pbw, dh = Height - Pbh;
                if (dw > 0 && dh > 0)
                {
                    Pbl = Point.Empty;
                    Pbs = Size;
                }
            }
            base.OnLayout(e);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            switch (SizeMode)
            {
                case PictureBoxSizeMode.Zoom: if (e.Delta > 0 && Size == Pbs) ScalingOn(); ScalePicture(e); break;
                case PictureBoxSizeMode.AutoSize: ScrollPicture(e); break;
            }
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
                    int dw = Width - Pbw, dh = Height - Pbh;
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
            selectionSize = new Size(Math.Abs(move2.X), Math.Abs(move2.Y));
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
                case PictureBoxSizeMode.Normal: SetPbd(DockStyle.Fill); break;
                case PictureBoxSizeMode.StretchImage: SetPbd(DockStyle.Fill); break;
                case PictureBoxSizeMode.AutoSize:
                    SetPbd(DockStyle.None); AutoScroll = true; Pbl = Point.Empty;
                    ScrollToCenter(); break;
                case PictureBoxSizeMode.CenterImage: SetPbd(DockStyle.Fill); break;
                case PictureBoxSizeMode.Zoom: SetPbd(DockStyle.Fill); break;
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = (Pbw > Width || Pbh > Height) &&
                (SizeMode == PictureBoxSizeMode.AutoSize || SizeMode == PictureBoxSizeMode.Zoom)
                ? overCur : Cursors.Default;
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
        Image CreateSelectionImage()
        {
            Image im = selectionSize.NewBitmap();
            using (Graphics gr = Graphics.FromImage(im))
                gr.CopyFromScreen(new Point(Math.Min(mouseStart.X, mouseEnd.X), Math.Min(mouseStart.Y, mouseEnd.Y)),
                    Point.Empty, selectionSize);
            return im;
        }
        private void cms_pc_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = Picture == null || move2 == Point.Empty;
        }
        private void cms_pc_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}

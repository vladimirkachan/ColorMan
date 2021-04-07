using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ControlsLibrary.Properties;
using ColorMan.ExtensionLibrary;

namespace ColorMan.ControlsLibrary
{
    public enum ZoomViewerAverageSize
    {
        Off = 0,
        X3 = 3,
        X5 = 5,
        X7 = 7,
        X9 = 9
    }

    public partial class ZoomViewer : LightingControl
    {
        readonly double[] zoomer = { 1, 2, 3, 4, 5, 7.5, 10, 15, 20, 30 };
        Color[][] area;
        readonly Cursor pipetteCur;
        bool picked;
        Color pickedColor, invertedColor;
        InterpolationMode interpolationMode = InterpolationMode.NearestNeighbor;
        Point position;
        public event EventHandler ColorPick;
        public event EventHandler LastValue;
        ZoomViewerAverageSize averageMode = ZoomViewerAverageSize.Off;
        Keys keyOn, smoothKey;
        Bitmap snapshot = LocalScreen.AllSize.NewBitmap();
        Graphics graphics;
        Point center;
        Size sourceSize, sourceLocation;
        Rectangle source;

        public ZoomViewerAverageSize AverageMode
        {
            get { return averageMode; }
            set
            {
                averageMode = value;
                int av = (int)value, a = 2 * av + 1;
                switch (value)
                {
                    case ZoomViewerAverageSize.Off: area = null; labelPick.Image = Resources.pipetteImg; return;
                    case ZoomViewerAverageSize.X3: labelPick.Image = Resources.pipetteImgX3; break;
                    case ZoomViewerAverageSize.X5: labelPick.Image = Resources.pipetteImgX5; break;
                    case ZoomViewerAverageSize.X7: labelPick.Image = Resources.pipetteImgX7; break;
                    case ZoomViewerAverageSize.X9: labelPick.Image = Resources.pipetteImgX9; break;
                }
                area = new Color[a][];
                for (int i = 0; i < a; i++) area[i] = new Color[a];
            }
        }
        public InterpolationMode InterpolationMode
        {
            get { return interpolationMode; }
            set
            {
                interpolationMode = value;
                labelInterpolation.Image = value == InterpolationMode.NearestNeighbor ? Resources.pixel : Resources.smooth;
            }
        }
        public IBaseSpace PickedSpace { get { return new Rgb(pickedColor); } }
        public Color PickedColor { get { return pickedColor; } }
        public bool Checked { get { return checkBox1.Checked; } set { checkBox1.Checked = value; } }
        public Image Picture
        {
            get
            {
                var picture = pictureBox1.Image;
                return picture ?? pictureBox1.Size.NewBitmap();
            }
            set
            {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = value;
            }
        }
        public Point Coordinate
        {
            get { return position; }
            set
            {
                position = value;
                PrintMousePosition();
            }
        }
        public int ZoomIndex { get { return trackBar1.Value; } set { trackBar1.Value = value; } }
        public ZoomViewerSettings CurrentSettings
        {
            get { return new ZoomViewerSettings(averageMode, interpolationMode, ZoomIndex); }
            set
            {
                if (value == null) return;
                AverageMode = value.AverageMode;
                InterpolationMode = value.InterpolationMode;
                ZoomIndex = value.ZoomIndex;
            }
        }
        public ZoomViewerData CurrentData
        {
            get
            {
                return new ZoomViewerData(CurrentSettings, snapshot, center, sourceSize, sourceLocation, source,
                    Coordinate, pickedColor, invertedColor, Picture);
            }
            set
            {
                CurrentSettings = value.CurrentSetting;
                snapshot = value.Snapshot;
                center = value.Center;
                sourceSize = value.SourceSize;
                sourceLocation = value.SourceLocation;
                source = value.Source;
                Coordinate = value.Coordinate;
                pickedColor = value.PickedColor;
                invertedColor = value.InvertedColor;
                Picture = value.Picture;
                labelDescription.SendToBack();
                OnColorPicked(null);
                OnLastValue(null);
            }
        }
        public Keys KeyOn
        {
            get { return keyOn; }
            set
            {
                keyOn = value;
                checkBox1.Text = value.ToString();
                toolTip1.SetToolTip(checkBox1, string.Format(CultureInfo.InvariantCulture,
                    "Key \"{0}\" or \"Space\" - On\nAny key - Off", value));
            }
        }
        public Keys SmoothKey
        {
            get { return smoothKey; }
            set
            {
                smoothKey = value;
                toolTip1.SetToolTip(labelInterpolation, string.Format(CultureInfo.InvariantCulture, "Key+{0}", value));
            }
        }
        public override Form Form
        {
            get { return base.Form; }
            set
            {
                base.Form = value;
                if (Form != null)
                {
                    Form.KeyDown += Form_KeyDown;
                    Form.Deactivate += Form_Deactivate;
                }
            }
        }
        public Size PictureSize { get { return pictureBox1.Size; } }
        public Point PictureLocation { get { return pictureBox1.ScreenLocation(); } }
        public ContextMenuStrip Cms { get { return cms_ZoomViewer; } }
        public bool Smooth { get { return InterpolationMode == InterpolationMode.Default; } }
        bool ZvFocused { get { return Controls.Cast<Control>().Any(item => item.Focused) || Focused; } }

        public ZoomViewer()
        {
            InitializeComponent();
            pipetteCur = new Cursor(GetType(), "Pipette.cur");
            pictureBox1.Cursor = pipetteCur;
            trackBar1_ValueChanged(null, null);
            avOff.Tag = ZoomViewerAverageSize.Off;
            avx3.Tag = ZoomViewerAverageSize.X3;
            avx5.Tag = ZoomViewerAverageSize.X5;
            avx7.Tag = ZoomViewerAverageSize.X7;
            avx9.Tag = ZoomViewerAverageSize.X9;
            KeyOn = Keys.P;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
        }

        public void Setting(string settings)
        {
            CurrentSettings = new ZoomViewerSettings(settings);
        }
        public void SetOuterImage(string fileName)
        {
            snapshot.Dispose();
            snapshot = new Bitmap(fileName);
            labelDescription.SendToBack();
            Coordinate = new Point(snapshot.Size.Divide(2));
            GetColors();
            SetSourceBounds();
            DrawPicture();
            OnColorPicked(null);
        }
        public void SwitchInterpolationMode(bool smooth)
        {
            InterpolationMode = smooth ? InterpolationMode.Default : InterpolationMode.NearestNeighbor;
            DrawPicture();
        }
        public void Stop()
        {
            timer1.Stop();
            OnLastValue(null);
        }
        void SwitchInterpolationMode()
        {
            InterpolationMode = interpolationMode == InterpolationMode.NearestNeighbor
            ? InterpolationMode.Default : InterpolationMode.NearestNeighbor;
            DrawPicture();
        }
        void Increment()
        {
            int i = trackBar1.Value + 1, max = trackBar1.Maximum;
            trackBar1.Value = i > max ? max : i;
        }
        void Decrement()
        {
            int i = trackBar1.Value - 1, min = trackBar1.Minimum;
            trackBar1.Value = i < min ? min : i;
        }
        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            if (keyCode == keyOn || (keyCode == Keys.Space && ZvFocused)) Checked = !Checked;
            else Checked = false;
        }
        void Form_Deactivate(object sender, EventArgs e)
        {
            Checked = false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Down:
                case Keys.Up: SwitchInterpolationMode(); return true;
                case Keys.Left: Decrement(); return true;
                case Keys.Right: Increment(); return true;
                case Keys.Tab: if (Checked) { Checked = false; return true; } break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnLoad(EventArgs e)
        {
            Layout += ZoomViewer_Layout;
            labelPick.MouseDown += control_MouseDown;
            pictureBox1.MouseDown += (sender, arg) => OnMouseDown(arg);
            pictureBox1.MouseMove += (sender, arg) => OnMouseMove(arg);
            pictureBox1.MouseUp += (sender, arg) => OnMouseUp(arg);
            MakeSnapshot();
            labelDescription.BringToFront();
            base.OnLoad(e);
        }
        void ZoomViewer_Layout(object sender, LayoutEventArgs e)
        {
            center = new Point(pictureBox1.Size.Divide(2));
            Picture = pictureBox1.Size.NewBitmap();
            SetSourceBounds();
            DrawPicture();
        }
        void SetSourceBounds()
        {
            double k = zoomer[ZoomIndex];
            sourceSize = pictureBox1.Size.Divide(k);
            sourceLocation = sourceSize.Divide(2);
        }
        void OnColorPicked(EventArgs e)
        {
            if (ColorPick != null) ColorPick(this, e);
        }
        void OnLastValue(EventArgs e)
        {
            if (LastValue != null) LastValue(this, e);
        }
        void MakeSnapshot()
        {
            snapshot.Dispose();
            snapshot = new Bitmap(LocalScreen.AllWidth, LocalScreen.AllHeight);
            using (graphics = Graphics.FromImage(snapshot))
                graphics.CopyFromScreen(Point.Empty, Point.Empty, LocalScreen.AllSize);
        }
        void GetColors()
        {
            pickedColor = GetAverageColor();
            invertedColor = pickedColor.Invert();
        }
        void DrawCrosshair()
        {
            int x = center.X, y = center.Y;
            graphics.DrawLine(new Pen(invertedColor), new Point(x - 10, y), new Point(x + 10, y));
            graphics.DrawLine(new Pen(invertedColor), new Point(x, y - 10), new Point(x, y + 10));
        }
        void DrawPicture()
        {
            pictureBox1.Invalidate();
            using (graphics = Graphics.FromImage(Picture))
            {
                graphics.InterpolationMode = interpolationMode;
                source = new Rectangle(Coordinate - sourceLocation, sourceSize);
                graphics.DrawImage(snapshot, pictureBox1.ClientRectangle, source, GraphicsUnit.Pixel);
                DrawCrosshair();
            }
        }
        Color GetAverageColor()
        {
            if (averageMode == ZoomViewerAverageSize.Off) 
                return snapshot.GetPixel(Coordinate.X.CutRange(0, LocalScreen.AllWidth - 1), Coordinate.Y.CutRange(0, LocalScreen.AllHeight - 1));
            FillArea();
            return area.AverageColor();
        }
        void FillArea()
        {
            for (int y = 0, ly = area.Length, my = ly / 2; y < ly; y++)
                for (int x = 0, lx = area[y].Length, mx = lx / 2; x < lx; x++)
                    area[y][x] = snapshot.GetPixel((Coordinate.X - mx + x).CutRange(0, LocalScreen.AllWidth - 1),
                                                   (Coordinate.Y - my + y).CutRange(0, LocalScreen.AllHeight - 1));
        }
        void Pick()
        {
            Coordinate = MousePosition;
            MakeSnapshot();
            GetColors();
            SetSourceBounds();
            DrawPicture();
            OnColorPicked(null);
        }
        void PrintMousePosition()
        {
            label1.Text = string.Format(CultureInfo.InvariantCulture, "x = {0}", position.X);
            label2.Text = string.Format(CultureInfo.InvariantCulture, "y = {0}", position.Y);
        }
        private void labelPick_MouseDown(object sender, MouseEventArgs e)
        {
            labelDescription.SendToBack();
            Checked = false;
            picked = true;
            labelPick.Cursor = pipetteCur;
        }
        private void labelPick_MouseMove(object sender, MouseEventArgs e)
        {
            if (picked) Pick();
        }
        private void labelPick_MouseUp(object sender, MouseEventArgs e)
        {
            picked = false;
            labelPick.Cursor = Cursors.Hand;
            OnLastValue(e);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked)
            {
                labelDescription.SendToBack();
                trackBar1.Focus();
                timer1.Start();
            }
            else Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Pick();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pickedColor = new Bitmap(Picture).GetPixel(e.X, e.Y);
            OnColorPicked(null);
            OnLastValue(null);
        }
        private void labelInterpolation_Click(object sender, EventArgs e)
        {
            SwitchInterpolationMode();
        }
        private void clear1_Click(object sender, EventArgs e)
        {
            using (Graphics gr = Graphics.FromImage(Picture)) gr.Clear(pictureBox1.BackColor);
            pictureBox1.Invalidate();
            labelDescription.BringToFront();
        }
        private void av_Click(object sender, EventArgs e)
        {
            var item = (ToolStripItem)sender;
            AverageMode = (ZoomViewerAverageSize)item.Tag;
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            SetSourceBounds();
            DrawPicture();
            toolTip1.SetToolTip(trackBar1, string.Format(CultureInfo.InvariantCulture, "{0:p0}", zoomer[ZoomIndex]));
        }
        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            Focus();
        }
        private void saveSnapshot1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.GetNextFileName("snapshot");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                snapshot.Save(saveFileDialog1.FileName);
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(saveFileDialog1.FileName);
            }
        }
        private void copySnapshot1_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(snapshot);
        }
        private void cms_ZoomViewer_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (timer1.Enabled) e.Cancel = true;
        }
    }
}

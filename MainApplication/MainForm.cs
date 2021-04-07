using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Windows.Forms;
using ColorMan.AppForms;
using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;
using ColorMan.ControlsLibrary;
using ColorMan.ExtensionLibrary;
using ColorMan.FormLibrary;
using ColorMan.Properties;
using CommonExtension = ColorMan.ExtensionLibrary.Extension;
using Extension = ColorMan.ColorSpaces.Extension;

namespace ColorMan
{
    public partial class MainForm : Form
    {
        #region AppForms

        readonly HsvHorizontalView hsvHorizontal = new HsvHorizontalView();
        readonly HsvVerticalView hsvVertical = new HsvVerticalView();
        readonly HslHorizontalView hslHorizontal = new HslHorizontalView();
        readonly HslVerticalView hslVertical = new HslVerticalView();
        readonly HsvCircleView hsvCircle = new HsvCircleView();
        readonly HslCircleView hslCircle = new HslCircleView();
        readonly RgbHorizontalView rgbHorizontal = new RgbHorizontalView();
        readonly RgbVerticalView rgbVertical = new RgbVerticalView();
        readonly LabHorizontalView labHorizontal = new LabHorizontalView();
        readonly LabVerticalView labVertical = new LabVerticalView();
        readonly CmykHorizontalView cmykHorizontal = new CmykHorizontalView();
        readonly CmykVerticalView cmykVertical = new CmykVerticalView();
        readonly LabSquareView labSquare = new LabSquareView();
        readonly HueHorizontalView hueHorizontal = new HueHorizontalView();
        readonly HueVerticalView hueVertical = new HueVerticalView();
        readonly HsvWheelView hsvWheel = new HsvWheelView();
        readonly HslWheelView hslWheel = new HslWheelView();
        readonly HLHorizontalView hlHorizontal = new HLHorizontalView();
        readonly HLVerticalView hlVertical = new HLVerticalView();
        readonly HsvWheelTriangleView hsvWheelTriangle = new HsvWheelTriangleView();
        readonly DialogForm dialog = new DialogForm();
        readonly TextEnterForm textEnter = new TextEnterForm();
        readonly InformationForm colorManInfo = new InformationForm(Resources.colorMan128, Hkey.ColorMan);

        #endregion

        public const string AppRegKey = Hkey.RootKey + "\\" + Hkey.ColorMan;
        const string Space1 = "Space1", Space2 = "Space2", Palette = "Palette", PaletteName = "PaletteName",
                     ZoomViewerSettings = "ZoomViewerSettings", NamedColorBoxSortBy = "NamedColorBoxSortBy", Error = "Error";
        static readonly Random rnd = new Random();
        readonly HsvAppSpace hsvAppSp = new HsvAppSpace();
        readonly CmykAppSpace cmykAppSp = new CmykAppSpace();
        readonly HslAppSpace hslAppSp = new HslAppSpace();
        readonly RgbAppSpace rgbAppSp = new RgbAppSpace();
        readonly LabAppSpace labAppSp = new LabAppSpace();
        readonly List<ILinkedItem<IBaseSpace>> parts = new List<ILinkedItem<IBaseSpace>>();
        readonly ILighting[] lightings;
        readonly Panel[] panels;
        Cursor dragCur;
        internal Type dragType;
        ColorLabel openedLabel;
        string paletteName = string.Empty;
        readonly IBaseSpace[] defaultPalette =
        {
            new Rgb(255, 64, 64), new Rgb(255, 128, 0), new Rgb(255, 255, 64),
            new Rgb(0, 191, 0), new Rgb(64, 255, 255), new Rgb(0, 0, 191), new Rgb(96, 0, 191), new Rgb(255, 0, 128),
            new Rgb(0, 0, 0), new Rgb(255, 255, 255)
        };
        readonly BinaryFormatter binaryFormatter = new BinaryFormatter();
        static TwoColorton Tc { get { return TwoColorton.Instance; } }

        public MainForm()
        {
            InitializeComponent();
            labVertical.Owner =
            hsvVertical.Owner =
            cmykVertical.Owner =
            hslVertical.Owner =
            rgbVertical.Owner =
            labSquare.Owner =
            labHorizontal.Owner =
            rgbHorizontal.Owner =
            hsvHorizontal.Owner =
            hslHorizontal.Owner =
            cmykHorizontal.Owner =
            hsvCircle.Owner =
            hslCircle.Owner =
            hueHorizontal.Owner =
            hueVertical.Owner =
            hsvWheel.Owner =
            hslWheel.Owner = hlHorizontal.Owner = hlVertical.Owner = hsvWheelTriangle.Owner = dialog.Owner = this;
            LinkedPairs(rgbHorizontal, rgbVertical);
            LinkedPairs(hslHorizontal, hslVertical);
            LinkedPairs(cmykHorizontal, cmykVertical);
            LinkedPairs(hsvHorizontal, hsvVertical);
            LinkedPairs(labHorizontal, labVertical);
            LinkedPairs(hueHorizontal, hueVertical);
            LinkedPairs(hlHorizontal, hlVertical);
            InitHsvSpace();
            InitCmykSpace();
            InitHslSpace();
            InitRgbSpace();
            InitLabSpace();
            InitHex();
            InitNamedColorsBox();
            InitColorBoxes();
            SetColorBoxBrushes();
            Tc.SpaceSwapped += TcSpaceSwapped;
            Tc.Space1Changed += TcSpace1Changed;
            Tc.Space2Changed += TcSpace2Changed;
            History history = History.Instance;
            history.BackBox = historyBox1;
            history.ForwardBox = historyBox2;
            history.InitValue(Tc.Space1);
            lightings = new ILighting[]
            {
                wrapNH, wrapNS, wrapNV, historyBox1, historyBox2, zoomViewer1, wrapTR, wrapTG, wrapTB, wrapTL, wrapTA,
                wrapTB2, wrapHex1, wrapHex2
            };
            panels = new[] { panelCenter, panelRight, panelLeft, panelTop2, panelTop1 };
            openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            textEnter.TextEntered += textEnter_TextEntered;
            chBoxOnTop.GotFocus += chBoxOnTop_GotFocus;
            chBoxOnTop.LostFocus += chBoxOnTop_LostFocus;
            SetMenuItems();
            fileSystemWatcher1.Filter = Hkey.ZoomViewerDat;
            fileSystemWatcher1.Path = CommonExtension.AppDataLocalFolder;
        }

        public static Image Cube(int side)
        {
            float r = (side - 1f) / 2f;
            const double Pi = Math.PI;
            PointF[] pnt = new PointF[6];
            float kx = (float)(r * Math.Cos(Pi / 6)), ky = (float)(r * Math.Sin(Pi / 6));
            float xl = r - kx, xr = r + kx, yt = r - ky, yb = r + ky;
            pnt[0] = new PointF(r, 0);
            pnt[1] = new PointF(xr, yt);
            pnt[2] = new PointF(xr, yb);
            pnt[3] = new PointF(r, side);
            pnt[4] = new PointF(xl, yb);
            pnt[5] = new PointF(xl, yt);
            PointF c = new PointF(r, r);
            var brush = new PathGradientBrush(pnt)
            {
                CenterPoint = c,
                SurroundColors = new[] { Color.Red, Color.Yellow, Color.Lime, Color.Cyan, Color.Blue, Color.Magenta },
                CenterColor = Color.White
            };
            Bitmap bmp = new Bitmap(side, side);
            using (Graphics gr = Graphics.FromImage(bmp)) gr.FillRectangle(brush, 0, 0, side, side);
            return bmp;
        }
        internal void ColorLabel1DragDrop(object sender, DragEventArgs e)
        {
            var source = (IColorSpace)e.Data.GetData(dragType);
            if (source == sender) dialog1_Click(sender, e);
            else MainNewValue1(source.Space);
        }
        internal void ColorLabel2DragDrop(object sender, DragEventArgs e)
        {
            var source = (IColorSpace)e.Data.GetData(dragType);
            if (source == sender) dialog1_Click(sender, e);
            else Tc.Space2 = source.Space;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            Keys keyCode = e.KeyCode;
            switch (keyCode)
            {
                case Keys.X:
                    if (mod != Keys.Control)
                    {
                        e.SuppressKeyPress = true;
                        Tc.Swap();
                    }
                    break;
            }
            base.OnKeyDown(e);
        }
        protected override void OnShown(EventArgs e)
        {
            rgbHorizontal.TopLeft();
            labHorizontal.TopRight();
            cmykHorizontal.TopCenter();
            hsvHorizontal.MiddleLeft();
            hslHorizontal.MiddleRight();
            hsvCircle.BottomLeft().Offset(0, -40);
            hslCircle.BottomRight().Offset(0, -40);
            hsvWheel.TopLeft();
            hslWheel.TopRight();
            hsvWheelTriangle.MiddleCenter();
            hlHorizontal.MiddleCenter();
            hueHorizontal.MiddleCenter().Offset(0, -hlHorizontal.Height);
            labSquare.BottomCenter().Offset(0, -40);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            timer1.Enabled = Visible;
            if (!Visible) return;
            foreach (Panel p in panels)
            {
                if (p.BackgroundImage != null) p.BackgroundImage.Dispose();
                p.BackgroundImage = CreateBorderImage(p, Color.Black);
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
            WindowState = FormWindowState.Normal;
            RegistryWrite();
        }
        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            if (!drgevent.Data.GetDataPresent(DataFormats.FileDrop)) return;
            drgevent.Effect = drgevent.KeyState == 1 ? DragDropEffects.Copy : DragDropEffects.Move;
        }
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            LoadFile(((string[])drgevent.Data.GetData(DataFormats.FileDrop))[0]);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RegistryRead();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 1) return;
            LoadFile(args[1]);
        }
        protected override void OnResize(EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) Hide();
        }
        void LoadFile(string fileName)
        {
            if (string.Equals(Path.GetExtension(fileName), ".plt", StringComparison.OrdinalIgnoreCase))
            {
                using (var sr = new StreamReader(fileName)) for (int i = 0; i < 10 && !sr.EndOfStream; i++) ((ColorLabel)panelTop2.Controls["label" + (i + 1)]).TypeAndHex = sr.ReadLine();
                SetPaletteName(fileName);
                openFileDialog1.InitialDirectory = saveFileDialog1.InitialDirectory = fileName;
            }
            else
                try
                {
                    zoomViewer1.SetOuterImage(fileName);
                }
                catch (Exception)
                {
                    return;
                }
        }
        void SetColorBoxBrushes()
        {
            triangle1.SetColorBoxesBrushes();
            hcbR.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(hcbR.Val, hcbG.Val, hcbB.Val));
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbR.Width, 0f), rgb.R1, rgb.R2);
            };
            hcbG.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(hcbR.Val, hcbG.Val, hcbB.Val));
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbG.Width, 0f), rgb.G1, rgb.G2);
            };
            hcbB.BrushFunc = () =>
            {
                Rgb rgb = new Rgb(new Vector(hcbR.Val, hcbG.Val, hcbB.Val));
                return new LinearGradientBrush(new PointF(0f, 0f), new PointF(hcbB.Width, 0f), rgb.B1, rgb.B2);
            };
            hcbL.BrushFunc = () =>
            {
                int n = hcbL.ColorCount;
                for (int i = 0; i < n; i++) hcbL.GetColors()[i] = Lab.FromLab(100f * i / (n - 1f), hcbA.Val * 255f - 128f, hcbB2.Val * 255f - 128f);
                return hcbL.UpdatedBrush();
            };
            hcbA.BrushFunc = () =>
            {
                int n = hcbA.ColorCount;
                for (int i = 0; i < n; i++) hcbA.GetColors()[i] = Lab.FromLab(hcbL.Val * 100f, 255f * i / (n - 1f) - 128f, hcbB2.Val * 255f - 128f);
                return hcbA.UpdatedBrush();
            };
            hcbB2.BrushFunc = () =>
            {
                int n = hcbB2.ColorCount;
                for (int i = 0; i < n; i++) hcbB2.GetColors()[i] = Lab.FromLab(hcbL.Val * 100f, hcbA.Val * 255f - 128f, 255f * i / (n - 1f) - 128f);
                return hcbB2.UpdatedBrush();
            };
        }
        void InitColorBoxes()
        {
            SetColorBoxBrushes();
            hcbR.Increment = hcbG.Increment = hcbB.Increment = hcbA.Increment = hcbB2.Increment = 1f / 255;
        }
        void InitHsvSpace()
        {
            hsvAppSp["H"].ValueChanged += hsvHorizontal.Hcbox1ValueChanged;
            hsvAppSp["S"].ValueChanged += hsvHorizontal.Hcbox2ValueChanged;
            hsvAppSp["V"].ValueChanged += hsvHorizontal.Hcbox3ValueChanged;
            hsvAppSp["H"].ValueChanged += hsvVertical.Vcbox1ValueChanged;
            hsvAppSp["S"].ValueChanged += hsvVertical.Vcbox2ValueChanged;
            hsvAppSp["V"].ValueChanged += hsvVertical.Vcbox3ValueChanged;
            hsvAppSp["H"].ValueChanged += hsvCircle.CB12ValueChanged;
            hsvAppSp["S"].ValueChanged += hsvCircle.CB12ValueChanged;
            hsvAppSp["V"].ValueChanged += hsvCircle.CB3ValueChanged;
            hsvAppSp["H"].ValueChanged += hsvWheel.WheelValueChanged;
            hsvAppSp["S"].ValueChanged += hsvWheel.SquareValueChanged;
            hsvAppSp["V"].ValueChanged += hsvWheel.SquareValueChanged;
            hsvWheel.WheelSquare1.Square1.Space =
            hsvCircle.CB12.Space = hsvWheelTriangle.picker.Space = triangle1.Space = hsvAppSp;
            hueHorizontal.AppSpace = hueVertical.AppSpace = hsvAppSp;
            hsvAppSp["H"].AddPacks(new Pack(triangle1.IwheelItem, nudH), hsvHorizontal[0], hsvVertical[0], hsvCircle[0],
                                   hueHorizontal[0], hueVertical[0], hsvWheel[0], hsvWheelTriangle[0]);
            hsvAppSp["S"].AddPacks(new Pack(triangle1.Iaitem, nudS), hsvHorizontal[1], hsvVertical[1], hsvCircle[1],
                                   hsvWheel[1], hsvWheelTriangle[1]);
            hsvAppSp["V"].AddPacks(new Pack(triangle1.Ihitem, nudV), hsvHorizontal[2], hsvVertical[2], hsvCircle[2],
                                   hsvWheel[2], hsvWheelTriangle[2]);
            hsvAppSp.NewValue += MainNewValue1;
            parts.Add(hsvAppSp);
        }
        void InitHslSpace()
        {
            hslAppSp["H"].ValueChanged += hslHorizontal.Hcbox1ValueChanged;
            hslAppSp["S"].ValueChanged += hslHorizontal.Hcbox2ValueChanged;
            hslAppSp["L"].ValueChanged += hslHorizontal.Hcbox3ValueChanged;
            hslAppSp["H"].ValueChanged += hslVertical.Vcbox1ValueChanged;
            hslAppSp["S"].ValueChanged += hslVertical.Vcbox2ValueChanged;
            hslAppSp["L"].ValueChanged += hslVertical.Vcbox3ValueChanged;
            hslAppSp["H"].ValueChanged += hslCircle.CB12ValueChanged;
            hslAppSp["S"].ValueChanged += hslCircle.CB12ValueChanged;
            hslAppSp["L"].ValueChanged += hslCircle.CB3ValueChanged;
            hslAppSp["H"].ValueChanged += hslWheel.WheelValueChanged;
            hslAppSp["S"].ValueChanged += hslWheel.SquareValueChanged;
            hslAppSp["L"].ValueChanged += hslWheel.SquareValueChanged;
            hslWheel.WheelSquare1.Square1.Space =
            hslCircle.CB12.Space = hlHorizontal.rectangleCB.Space = hlVertical.rectangleCB.Space = hslAppSp;
            hlHorizontal.AppSpace = hlVertical.AppSpace = hslAppSp;
            hslAppSp["H"].AddPacks(hslHorizontal[0], hslVertical[0], hslCircle[0], hslWheel[0], hlHorizontal[0],
                                   hlVertical[0]);
            hslAppSp["S"].AddPacks(hslHorizontal[1], hslVertical[1], hslCircle[1], hslWheel[1]);
            hslAppSp["L"].AddPacks(hslHorizontal[2], hslVertical[2], hslCircle[2], hslWheel[2], hlHorizontal[1],
                                   hlVertical[1]);
            hslAppSp.NewValue += MainNewValue1;
            parts.Add(hslAppSp);
        }
        void InitCmykSpace()
        {
            cmykAppSp["C"].ValueChanged += cmykHorizontal.Hcbox1ValueChanged;
            cmykAppSp["M"].ValueChanged += cmykHorizontal.Hcbox2ValueChanged;
            cmykAppSp["Y"].ValueChanged += cmykHorizontal.Hcbox3ValueChanged;
            cmykAppSp["K"].ValueChanged += cmykHorizontal.Hcbox4ValueChanged;
            cmykAppSp["C"].ValueChanged += cmykVertical.Vcbox1ValueChanged;
            cmykAppSp["M"].ValueChanged += cmykVertical.Vcbox2ValueChanged;
            cmykAppSp["Y"].ValueChanged += cmykVertical.Vcbox3ValueChanged;
            cmykAppSp["K"].ValueChanged += cmykVertical.Vcbox4ValueChanged;
            cmykAppSp["C"].AddPacks(cmykHorizontal[0], cmykVertical[0]);
            cmykAppSp["M"].AddPacks(cmykHorizontal[1], cmykVertical[1]);
            cmykAppSp["Y"].AddPacks(cmykHorizontal[2], cmykVertical[2]);
            cmykAppSp["K"].AddPacks(cmykHorizontal[3], cmykVertical[3]);
            cmykAppSp.NewValue += MainNewValue1;
            parts.Add(cmykAppSp);
        }
        void InitRgbSpace()
        {
            rgbAppSp["R"].ValueChanged += rgbHorizontal.Hcbox1ValueChanged;
            rgbAppSp["G"].ValueChanged += rgbHorizontal.Hcbox2ValueChanged;
            rgbAppSp["B"].ValueChanged += rgbHorizontal.Hcbox3ValueChanged;
            rgbAppSp["R"].ValueChanged += rgbVertical.Vcbox1ValueChanged;
            rgbAppSp["G"].ValueChanged += rgbVertical.Vcbox2ValueChanged;
            rgbAppSp["B"].ValueChanged += rgbVertical.Vcbox3ValueChanged;
            rgbAppSp["R"].AddPacks(new Pack(hcbR, ntbR), rgbHorizontal[0], rgbVertical[0]);
            rgbAppSp["G"].AddPacks(new Pack(hcbG, ntbG), rgbHorizontal[1], rgbVertical[1]);
            rgbAppSp["B"].AddPacks(new Pack(hcbB, ntbB), rgbHorizontal[2], rgbVertical[2]);
            rgbAppSp.NewValue += MainNewValue1;
            parts.Add(rgbAppSp);
        }
        void InitLabSpace()
        {
            labAppSp["L"].ValueChanged += labHorizontal.Hcbox1ValueChanged;
            labAppSp["A"].ValueChanged += labHorizontal.Hcbox2ValueChanged;
            labAppSp["B"].ValueChanged += labHorizontal.Hcbox3ValueChanged;
            labAppSp["L"].ValueChanged += labVertical.Vcbox1ValueChanged;
            labAppSp["A"].ValueChanged += labVertical.Vcbox2ValueChanged;
            labAppSp["B"].ValueChanged += labVertical.Vcbox3ValueChanged;
            labAppSp["L"].ValueChanged += labSquare.LinearValueChanged;
            labAppSp["A"].ValueChanged += labSquare.SquareValueChanged;
            labAppSp["B"].ValueChanged += labSquare.SquareValueChanged;
            labAppSp["L"].AddPacks(new Pack(hcbL, ntbL), labHorizontal[0], labVertical[0], labSquare[0]);
            labAppSp["A"].AddPacks(new Pack(hcbA, ntbA), labHorizontal[1], labVertical[1], labSquare[1]);
            labAppSp["B"].AddPacks(new Pack(hcbB2, ntbB2), labHorizontal[2], labVertical[2], labSquare[2]);
            labSquare.SquareCb.Space = labAppSp;
            labAppSp.NewValue += MainNewValue1;
            parts.Add(labAppSp);
        }
        void InitHex()
        {
            tbHex1.NewValue += SetNewValue1;
            tbHex1.NewValue += MainNewValue1;
            parts.Add(tbHex1);
            tbHex2.NewValue += SetNewValue2;
        }
        void InitNamedColorsBox()
        {
            namedColorBox1.SetDataSource(Extension.WebColors);
            namedColorBox1.NewValue += SetNewValue1;
            namedColorBox1.NewValue += MainNewValue1;
            parts.Add(namedColorBox1);
            sortByName1.Tag = ColorSortingBy.Name;
            sortByHue1.Tag = ColorSortingBy.Hue;
            sortBySaturation1.Tag = ColorSortingBy.Saturation;
            sortByLightness1.Tag = ColorSortingBy.Lightness;
            sortByValue1.Tag = ColorSortingBy.Value;
        }
        void SetMenuItems()
        {
            hsvHorizontal.SetMenuItemElement(hsvLineItem);
            hsvVertical.SetMenuItemElement(hsvLineItem);
            hslHorizontal.SetMenuItemElement(hslLineItem);
            hslVertical.SetMenuItemElement(hslLineItem);
            hsvCircle.SetMenuItemElement(hsvCircleItem);
            hslCircle.SetMenuItemElement(hslCircleItem);
            rgbHorizontal.SetMenuItemElement(rgbLineItem);
            rgbVertical.SetMenuItemElement(rgbLineItem);
            labHorizontal.SetMenuItemElement(labLineItem);
            labVertical.SetMenuItemElement(labLineItem);
            cmykHorizontal.SetMenuItemElement(cmykLineItem);
            cmykVertical.SetMenuItemElement(cmykLineItem);
            labSquare.SetMenuItemElement(labSquareItem);
            hueHorizontal.SetMenuItemElement(hsvHueItem);
            hueVertical.SetMenuItemElement(hsvHueItem);
            hsvWheel.SetMenuItemElement(hsvWheelItem);
            hslWheel.SetMenuItemElement(hslWheelItem);
            hlHorizontal.SetMenuItemElement(hslHLItem);
            hlVertical.SetMenuItemElement(hslHLItem);
            hsvWheelTriangle.SetMenuItemElement(hsvTriangleItem);
        }
        void RegistryWrite()
        {
            var data = new Dictionary<string, object>();
            data[Space1] = colorLabel1.TypeAndHex;
            data[Space2] = colorLabel2.TypeAndHex;
            var palette = new string[10];
            for (int i = 0; i < 10; i++) palette[i] = ((ColorLabel)panelTop2.Controls["label" + (i + 1)]).TypeAndHex;
            data[Palette] = palette;
            data[PaletteName] = paletteName;
            data[ZoomViewerSettings] = zoomViewer1.CurrentSettings;
            data[NamedColorBoxSortBy] = namedColorBox1.SortBy;
            data[Hkey.OnTop] = chBoxOnTop.Checked;
            data[Hkey.LocationX] = Left;
            data[Hkey.LocationY] = Top;
            CommonExtension.RegistryWrite(AppRegKey, data);
        }
        void RegistryRead()
        {
            try
            {
                string[] names =
                {
                    Space1, Space2, Palette, PaletteName, ZoomViewerSettings, NamedColorBoxSortBy, Hkey.OnTop,
                    Hkey.LocationX, Hkey.LocationY
                };
                var data = CommonExtension.RegistryRead(AppRegKey, names);
                IBaseSpace space1 = GetRandomRgb(), space2 = GetRandomRgb();
                if (data.ContainsKey(Space1)) SpaceParser.TryGetSpaceFromTypeAndHex(data[Space1].ToString(), out space1);
                if (data.ContainsKey(Space2)) SpaceParser.TryGetSpaceFromTypeAndHex(data[Space2].ToString(), out space2);
                InitSpacesValue(space1, space2);
                if (data.ContainsKey(Palette))
                {
                    var palette = (string[])data[Palette];
                    for (int i = 0; i < 10; i++) ((ColorLabel)panelTop2.Controls["label" + (i + 1)]).TypeAndHex = palette[i];
                }
                if (data.ContainsKey(PaletteName)) paletteName = data[PaletteName].ToString();
                Text = !string.IsNullOrEmpty(paletteName)
                ? string.Format(CultureInfo.InvariantCulture, "{0} - {1}", Hkey.ColorMan, paletteName) : Hkey.ColorMan;
                if (data.ContainsKey(ZoomViewerSettings)) zoomViewer1.Setting(data[ZoomViewerSettings].ToString());
                if (data.ContainsKey(NamedColorBoxSortBy))
                {
                    ColorSortingBy sortBy;
                    string sort = data[NamedColorBoxSortBy].ToString();
                    if (Enum.TryParse(sort, out sortBy)) namedColorBox1.Sort(sortBy);
                }
                if (data.ContainsKey(Hkey.OnTop))
                {
                    bool onTop;
                    string top = data[Hkey.OnTop].ToString();
                    if (bool.TryParse(top, out onTop)) chBoxOnTop.Checked = onTop;
                }
                if (!data.ContainsKey(Hkey.LocationX) || !data.ContainsKey(Hkey.LocationY)) return;
                Location = new Point((int)data[Hkey.LocationX], (int)data[Hkey.LocationY]);
                this.ToScreenBounds();
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
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, Error, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        void InitSpacesValue(IBaseSpace space1, IBaseSpace space2)
        {
            MainNewValue1(space1);
            Tc.Space2 = space2;
        }
        void TcSpaceSwapped(object sender, EventArgs se)
        {
            MainNewValue1(Tc.Space1);
            TcSpace2Changed(sender, se);
        }
        void TcSpace1Changed(object sender, EventArgs e)
        {
            var space = Tc.Space1;
            gradientPicker1.Color1 = space.ToColor();
            colorLabel1.Space = space;
        }
        void TcSpace2Changed(object sender, EventArgs e)
        {
            var space = Tc.Space2;
            gradientPicker1.Color2 = space.ToColor();
            colorLabel2.Space = space;
            if (!tbHex2.Focused) tbHex2.SetValIn(space);
        }
        static void LinkedPairs(AppForms.View view1, AppForms.View view2)
        {
            view1.Pair = view2;
            view2.Pair = view1;
        }
        void MainNewValue1(IBaseSpace space)
        {
            Tc.Space1 = space;
            foreach (var item in parts) item.SetValIn(space);
        }
        void MainNewValue1(object sender, LinkedItemEventArgs<IBaseSpace> args)
        {
            foreach (var item in parts) if (item != sender) item.SetValIn(args.Val);
        }
        static void SetNewValue1(object sender, LinkedItemEventArgs<IBaseSpace> args)
        {
            Tc.Space1 = args.Val;
        }
        void SetNewValue2(object sender, LinkedItemEventArgs<IBaseSpace> args)
        {
            Tc.Space2 = tbHex2.Val;
        }
        static IBaseSpace GetRandomRgb()
        {
            return new Rgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        static Image CreateBorderImage(Control control, Color color)
        {
            int w = control.Width, h = control.Height;
            Bitmap bmp = new Bitmap(w + 1, h + 1);
            Padding padding = control.Padding;
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                Brush brush = new SolidBrush(color);
                gr.FillRectangle(brush, 0, 0, w, padding.Top);
                int bottom = padding.Bottom;
                gr.FillRectangle(brush, 0, h - bottom, w, bottom);
                gr.FillRectangle(brush, 0, 0, padding.Left, h);
                int right = padding.Right;
                gr.FillRectangle(brush, w - right, 0, right, h);
            }
            return bmp;
        }
        void OpenPalette()
        {
            try
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    for (int i = 1; ;)
                    {
                        if (sr.EndOfStream || i > 10) break;
                        string line = (sr.ReadLine() ?? string.Empty).Trim();
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var colorLabel = (ColorLabel)panelTop2.Controls["label" + i++];
                        colorLabel.SpaceChanged -= paletteLabel_SpaceChanged;
                        if (!colorLabel.TrySetTypeAndHex(line)) throw new ArgumentException(line);
                        colorLabel.SpaceChanged += paletteLabel_SpaceChanged;
                    }
                SetPaletteName(openFileDialog1.FileName);
            }
            catch (ArgumentNullException e)
            {
                OpenedErrorMessage(e.Message);
            }
            catch (ArgumentException e)
            {
                OpenedErrorMessage(e.Message);
            }
            catch (FileNotFoundException e)
            {
                OpenedErrorMessage(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                OpenedErrorMessage(e.Message);
            }
            catch (IOException e)
            {
                OpenedErrorMessage(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                OpenedErrorMessage(e.Message);
            }
        }
        void OpenedErrorMessage(string message)
        {
            MessageBox.Show(message + @" is not a valid value of color space", Hkey.ColorMan, MessageBoxButtons.OK,
                            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            Activate();
        }
        void SavePalette()
        {
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                for (int i = 1; i <= 10; i++) sw.WriteLine(((ColorLabel)panelTop2.Controls["label" + i]).TypeAndHex);
            SetPaletteName(saveFileDialog1.FileName);
        }
        void SetPaletteName(string fileName)
        {
            paletteName = Path.GetFileName(fileName);
            Text = string.Format(CultureInfo.InvariantCulture, @"{0} - {1}", Hkey.ColorMan, paletteName);
        }
        void PastedErrorMessage(string text)
        {
            MessageBox.Show(text + @" is not a valid string value of color space", Hkey.ColorMan, MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Activate();
        }
        void SetSpaceToColorLabel(ColorLabel colorLabel, IBaseSpace space)
        {
            switch (colorLabel.Name)
            {
                case "colorLabel1":
                    MainNewValue1(space);
                    break;
                case "colorLabel2":
                    Tc.Space2 = space;
                    break;
                default:
                    colorLabel.Space = space;
                    break;
            }
        }
        void textEnter_TextEntered(object sender, EventArgs e)
        {
            string input = textEnter.InputText;
            if (!openedLabel.TrySetTypeAndHex(input))
            {
                MessageBox.Show(input + @" is not a valid of color space name and hex\n'SPACE XXXXXX'", Hkey.ColorMan,
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            switch (openedLabel.Name)
            {
                case "colorLabel1":
                    MainNewValue1(openedLabel.Space);
                    break;
                case "colorLabel2":
                    Tc.Space2 = openedLabel.Space;
                    break;
            }
        }
        void chBoxOnTop_LostFocus(object sender, EventArgs e)
        {
            chBoxOnTop.ForeColor = Color.Black;
            chBoxOnTop.BackColor = SystemColors.WindowFrame;
        }
        void chBoxOnTop_GotFocus(object sender, EventArgs e)
        {
            chBoxOnTop.ForeColor = Color.White;
            chBoxOnTop.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void paletteLabel_SpaceChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(paletteName) && Text[Text.Length - 1] != '*') Text += '*';
        }
        private void colorLabel12_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) dialog.ShowDialog();
        }
        private void rgbLine_Click(object sender, EventArgs e)
        {
            if (rgbHorizontal.Visible) rgbHorizontal.Hide();
            else if (rgbVertical.Visible) rgbVertical.Hide();
            else rgbHorizontal.Show();
        }
        private void hsvLine_Click(object sender, EventArgs e)
        {
            if (hsvHorizontal.Visible) hsvHorizontal.Hide();
            else if (hsvVertical.Visible) hsvVertical.Hide();
            else hsvHorizontal.Show();
        }
        private void hsvCircle_Click(object sender, EventArgs e)
        {
            hsvCircle.Visible = !hsvCircle.Visible;
        }
        private void hsvWheelSquare_Click(object sender, EventArgs e)
        {
            hsvWheel.Visible = !hsvWheel.Visible;
        }
        private void hsvWheelTriangle_Click(object sender, EventArgs e)
        {
            hsvWheelTriangle.Visible = !hsvWheelTriangle.Visible;
        }
        private void hsvHue_Click(object sender, EventArgs e)
        {
            if (hueHorizontal.Visible) hueHorizontal.Hide();
            else if (hueVertical.Visible) hueVertical.Hide();
            else hueHorizontal.Show();
        }
        private void hslLine_Click(object sender, EventArgs e)
        {
            if (hslHorizontal.Visible) hslHorizontal.Hide();
            else if (hslVertical.Visible) hslVertical.Hide();
            else hslHorizontal.Show();
        }
        private void hslCircle_Click(object sender, EventArgs e)
        {
            hslCircle.Visible = !hslCircle.Visible;
        }
        private void hslWheelSquare_Click(object sender, EventArgs e)
        {
            hslWheel.Visible = !hslWheel.Visible;
        }
        private void hslHueLightness_Click(object sender, EventArgs e)
        {
            if (hlHorizontal.Visible) hlHorizontal.Hide();
            else if (hlVertical.Visible) hlVertical.Hide();
            else hlHorizontal.Show();
        }
        private void cmykLine_Click(object sender, EventArgs e)
        {
            if (cmykHorizontal.Visible) cmykHorizontal.Hide();
            else if (cmykVertical.Visible) cmykVertical.Hide();
            else cmykHorizontal.Show();
        }
        private void labLine_Click(object sender, EventArgs e)
        {
            if (labHorizontal.Visible) labHorizontal.Hide();
            else if (labVertical.Visible) labVertical.Hide();
            else labHorizontal.Show();
        }
        private void labSquare_Click(object sender, EventArgs e)
        {
            labSquare.Visible = !labSquare.Visible;
        }
        private void hcbR_ValueChanged(object sender, EventArgs e)
        {
            hcbG.Invalidate();
            hcbB.Invalidate();
        }
        private void hcbG_ValueChanged(object sender, EventArgs e)
        {
            hcbR.Invalidate();
            hcbB.Invalidate();
        }
        private void hcbB_ValueChanged(object sender, EventArgs e)
        {
            hcbR.Invalidate();
            hcbG.Invalidate();
        }
        private void hcbL_ValueChanged(object sender, EventArgs e)
        {
            hcbA.Invalidate();
            hcbB2.Invalidate();
        }
        private void hcbA_ValueChanged(object sender, EventArgs e)
        {
            hcbL.Invalidate();
            hcbB2.Invalidate();
        }
        private void hcbB2_ValueChanged(object sender, EventArgs e)
        {
            hcbL.Invalidate();
            hcbA.Invalidate();
        }
        private void zoomViewer_ColorPick(object sender, EventArgs e)
        {
            MainNewValue1(zoomViewer1.PickedSpace);
        }
        private void colorPicker1_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            Point loc = zoomViewer1.ScreenLocation(), pos = new Point(LocalScreen.Width / 2, LocalScreen.Height / 2);
            var data = new Dictionary<string, object>();
            data[Hkey.PictureLocationX] = loc.X;
            data[Hkey.PictureLocationY] = loc.Y;
            data[Hkey.PictureCenterX] = pos.X;
            data[Hkey.PictureCenterY] = pos.Y;
            data[Hkey.DirectingPlace] = @"Match";
            data[Hkey.ZoomViewerSettings] = zoomViewer1.CurrentSettings;
            CommonExtension.RegistryWrite(Hkey.RootKey + "\\" + Hkey.ColorPicker, data);
            string executablePath =
            (string)
            CommonExtension.RegistryRead(Hkey.RootKey + "\\" + Hkey.ColorPicker, Hkey.ExecutablePath);
            if (executablePath != null && File.Exists(executablePath)) Process.Start(executablePath);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            MainNewValue1(GetRandomRgb());
            item_LastValue(null, null);
        }
        private void btnInvert_Click(object sender, EventArgs e)
        {
            MainNewValue1(new Rgb(Tc.Space1.ToColor().Invert()));
            item_LastValue(null, null);
        }
        private void dialog1_Click(object sender, EventArgs e)
        {
            dialog.Space = Tc.Space1;
            if (dialog.ShowDialog() == DialogResult.OK) MainNewValue1(dialog.Space);
        }
        private void historyBox1_Execute(object sender, EventArgs e)
        {
            MainNewValue1(History.Instance.Back());
        }
        private void historyBox2_Execute(object sender, EventArgs e)
        {
            MainNewValue1(History.Instance.Forward());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var l in lightings.Where(l => l.CanLight()))
                if (l.IsInside()) l.LightOn();
                else l.LightOff();
        }
        private void item_LastValue(object sender, EventArgs e)
        {
            History.Instance.SetCurrentValue(Tc.Space1);
        }
        private void drag_MouseDown(object sender, MouseEventArgs e)
        {
            var control = (Control)sender;
            var panel = control.Parent;
            if (e.Button == MouseButtons.Left)
            {
                dragType = control.GetType();
                dragCur = ((IColorSpace)control).Space.CreateCursor();
                panel.DoDragDrop(control, DragDropEffects.Move);
            }
        }
        private void paletteLabel_DragDrop(object sender, DragEventArgs e)
        {
            var source = (IColorSpace)e.Data.GetData(dragType);
            var target = (ColorLabel)sender;
            var space = source.Space;
            if (source != target) target.Space = space;
            else MainNewValue1(space);
            item_LastValue(null, null);
        }
        private void panelTop1_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
            Cursor.Current = e.Effect == DragDropEffects.Move ? dragCur : Cursors.No;
        }
        private void gradientPicker1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gradientPicker1.IsPicked) drag_MouseDown(sender, e);
        }
        private void undrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            OpenPalette();
            openFileDialog1.InitialDirectory =
            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.GetNextFileName("palette");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SavePalette();
                openFileDialog1.InitialDirectory =
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(saveFileDialog1.FileName);
            }
        }
        private void nearest1_Click(object sender, EventArgs e)
        {
            namedColorBox1.GetNearest();
        }
        private void sortNamedColorBox_Click(object sender, EventArgs e)
        {
            namedColorBox1.Sort((ColorSortingBy)((ToolStripItem)sender).Tag);
        }
        private void btnWeb_Click(object sender, EventArgs e)
        {
            nearest1_Click(sender, e);
        }
        private void swap1_Click(object sender, EventArgs e)
        {
            Tc.Swap();
        }
        private void change_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            openedLabel = (ColorLabel)((ContextMenuStrip)item.GetCurrentParent()).SourceControl;
            textEnter.InputText = openedLabel.TypeAndHex;
            textEnter.Location = openedLabel.ScreenLocation() + new Size(openedLabel.Width / 2, openedLabel.Height / 2);
            textEnter.Show();
        }
        private void copy_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var colorLabel = (ColorLabel)((ContextMenuStrip)item.GetCurrentParent()).SourceControl;
            Clipboard.SetText(colorLabel.TypeAndHex);
        }
        private void paste_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            var colorLabel = (ColorLabel)((ContextMenuStrip)item.GetCurrentParent()).SourceControl;
            string text = Clipboard.GetText();
            IBaseSpace space;
            if (!SpaceParser.TryGetSpaceFromTypeAndHex(text, out space))
            {
                if (text.IsWebColor()) space = new Rgb(Color.FromName(text));
                else
                    try
                    {
                        space = new Rgb(text.ToColor());
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        PastedErrorMessage(text);
                        return;
                    }
                    catch (ArgumentNullException)
                    {
                        PastedErrorMessage(text);
                        return;
                    }
                    catch (ArgumentException)
                    {
                        PastedErrorMessage(text);
                        return;
                    }
                    catch (FormatException)
                    {
                        PastedErrorMessage(text);
                        return;
                    }
                    catch (OverflowException)
                    {
                        PastedErrorMessage(text);
                        return;
                    }
                    catch (Exception)
                    {
                        PastedErrorMessage(text);
                    }
            }
            SetSpaceToColorLabel(colorLabel, space);
        }
        private void btnDefault_Click(object sender, EventArgs e)
        {
            paletteName = string.Empty;
            Text = Hkey.ColorMan;
            for (int i = 0; i < 10; i++) ((ColorLabel)panelTop2.Controls["label" + (i + 1)]).Space = defaultPalette[i];
        }
        private void chBoxOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chBoxOnTop.Checked;
        }
        private void cms_colorLabel_Opening(object sender, CancelEventArgs e)
        {
            paste1.Enabled = paste2.Enabled = Clipboard.ContainsText();
        }
        private void compact1_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
            var processes = Process.GetProcessesByName(Hkey.CompactViewer);
            if (processes.Length == 0)
            {
                string executablePath =
                (string)
                CommonExtension.RegistryRead(Hkey.RootKey + "\\" + Hkey.CompactViewer, Hkey.ExecutablePath);
                if (executablePath != null)
                    Process.Start(executablePath);
            }
            else NativeMethods.SetForeground(processes[0].MainWindowHandle);
            Cursor = Cursors.Default;
            caller.Enabled = true;
        }
        private void multiple1_Click(object sender, EventArgs e)
        {
            var caller = (ToolStripItem)sender;
            caller.Enabled = false;
            Cursor = Cursors.AppStarting;
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
        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            var process = Process.GetCurrentProcess();
            NativeMethods.SetForeground(process.MainWindowHandle);
            string path = CommonExtension.AppDataLocalFolder + "\\" + Hkey.ZoomViewerDat;
            if (!File.Exists(path)) return;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
                zoomViewer1.CurrentData = binaryFormatter.Deserialize(fs) as ZoomViewerData;
        }
        private void exitColorMan1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void about_Click(object sender, EventArgs e)
        {
            switch (TopMost)
            {
                case false: colorManInfo.ShowDialog(); break;
                case true: TopMost = false; colorManInfo.ShowDialog(); TopMost = true; break;
            }
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void exitAllTr_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            foreach (var pr in Process.GetProcessesByName(Hkey.CompactViewer)) pr.Kill();
            foreach (var pr in Process.GetProcessesByName(Hkey.MultipleViewer)) pr.Kill();
            foreach (var pr in Process.GetProcessesByName(Hkey.ColorPicker)) pr.Kill();
            foreach (var pr in Process.GetProcessesByName(Hkey.ColorMan))
            {
                var current = Process.GetCurrentProcess();
                if (pr != current) pr.Kill();
            }
            Close();
        }
        private void closeAll1_Click(object sender, EventArgs e)
        {
            foreach (var f in OwnedForms) f.Hide();
        }
        private void colorManTr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) notifyIcon1_DoubleClick(sender, e);
        }
    }
}

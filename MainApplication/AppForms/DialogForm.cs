using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ColorMan.ColorSpaces;
using ColorMan.ContractLibrary;
using ColorMan.ControlsLibrary;

namespace ColorMan.AppForms
{
    public partial class DialogForm : Form
    {
        const string hue1 = "hue", hue2 = "h\r\nu\r\ne", saturation1 = "saturation",
                        saturation2 = "s\r\na\r\nt\r\nu\r\nr\r\na\r\nt\r\ni\r\no\r\nn", value2 = "v\r\na\r\nl\r\nu\r\ne", 
                        lightness2 = "l\r\ni\r\ng\r\nh\r\nt\r\nn\r\ne\r\ns\r\ns", red1 = "red", red2 = "r\r\ne\r\nd",
                        green2 = "g\r\nr\r\ne\r\ne\r\nn", blue1 = "blue", blue2 = "b\r\nl\r\nu\r\ne",
                        l = "L", a = "a", b = "b";
        const string HSL = "HSL", HSV = "HSV", LAB = "LAB", RGB = "RGB";
        Func<Vector> vector;
        Func<float, Vector> linearVector;
        Func<float, float, Vector> squareVector;
        Func<Vector, Vector> replacer;
        readonly Dictionary<RadioButton, Action> setKind = new Dictionary<RadioButton, Action>();
        public IBaseSpace Space { get { return tbHex.Val; } set { tbHex.SetValIn(value); } }
        IVectorSpace VectorSpace { get { return (IVectorSpace)Space; } set { Space = (IBaseSpace)value; } }
        public DialogForm()
        {
            InitializeComponent();
            linear.NewValue += linear_NewValue;
            InitRadioButton();
            square.SelectedColorFunc = () => VectorSpace.FromSpace(vector());
            tbHex.NewValue += tbHex_NewValue;
        }

        void tbHex_NewValue(object sender, LinkedItemEventArgs<IBaseSpace> args)
        {
            Text = Space.ToString();
            SetValInColorBoxes();
            clNew.Space = Space;
        }
        void linear_NewValue(object sender, LinkedItemEventArgs<float> args)
        {
            NewSpace();
        }
        void NewSpace()
        {
            VectorSpace = VectorSpace.Create(vector());
            Text = VectorSpace.ToString();
            clNew.Space = Space;
        }
        void InitRadioButton()
        {
            setKind[rbHsvH] = OnHsvH;
            setKind[rbHsvS] = OnHsvS;
            setKind[rbHsvV] = OnHsvV;
            setKind[rbHslH] = OnHslH;
            setKind[rbHslS] = OnHslS;
            setKind[rbHslL] = OnHslL;
            setKind[rbRgbR] = OnRgbR;
            setKind[rbRgbG] = OnRgbG;
            setKind[rbRgbB] = OnRgbB;
            setKind[rbLabL] = OnLabL;
            setKind[rbLabA] = OnLabA;
            setKind[rbLabB] = OnLabB;
            List<GroupRadioButton> group = new List<GroupRadioButton>(12);
            foreach (Control ctrl in panel1.Controls)
            {
                GroupRadioButton rb = ctrl as GroupRadioButton;
                if (rb == null) return;
                rb.LostFocus += Rb_LostFocus;
                group.Add(rb);
                group.Sort((button1, button2) => button1.TabIndex - button2.TabIndex);
                rb.Outer = wrapL;
                rb.SetGroup(group);
            }
        }
        void OnHsvH()
        {
            tbHex.SwitchSpaceType(HSV);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector(linear.Val, (float)square.Val1, (float)square.Val2);
            linearVector = val => new Vector(val, (float)square.Val1, (float)square.Val2);
            squareVector = (x, y) => new Vector(linear.Val, x, y);
            replacer = v => new Vector(v.CoordinateX, v.CoordinateY, v.CoordinateZ);
            linear.SetValIn(value.CoordinateX);
            square.SetValIn(value.CoordinateY, value.CoordinateZ);
            linear.ColorCount = 7;
            linear.BrushFunc = () =>
            {
                Color[] colors = new Hsv(vector()).GetHueColors();
                Array.Reverse(colors);
                linear.SetColors(colors);
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Hsv.FromHsv(new Vector(linear.Val, p.X, p.Y)).GetBrightness();
            };
            square.ColorCount = 2;
            SetColorComponentName(hue2, saturation1, value2);
            linear.Increment = 1f / 360f;
            square.Increment1 = square.Increment2 = 0.01;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            linearPointer.Maximum = 360;
            squarePointer1.Maximum = squarePointer2.Maximum = 100;
        }
        void OnHsvS()
        {
            tbHex.SwitchSpaceType(HSV);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val1, linear.Val, (float)square.Val2);
            linearVector = val => new Vector((float)square.Val1, val, (float)square.Val2);
            squareVector = (x, y) => new Vector(x, linear.Val, y);
            replacer = v => new Vector(v.CoordinateY, v.CoordinateX, v.CoordinateZ);
            linear.SetValIn(value.CoordinateY);
            square.SetValIn(value.CoordinateX, value.CoordinateZ);
            linear.ColorCount = 2;
            linear.BrushFunc = () =>
            {
                linear.GetColors()[0] = Hsv.FromHsv(linearVector(1f));
                linear.GetColors()[1] = Hsv.FromHsv(linearVector(0f));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Hsv.FromHsv(new Vector(p.X, linear.Val, p.Y)).GetBrightness();
            };
            square.ColorCount = 2;
            SetColorComponentName(saturation2, hue1, value2);
            linear.Increment = 0.01f;
            square.Increment1 = 1.0 / 360.0;
            square.Increment2 = 0.01;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            squarePointer1.Maximum = 360;
            linearPointer.Maximum = squarePointer2.Maximum = 100;
        }
        void OnHsvV()
        {
            tbHex.SwitchSpaceType(HSV);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val1, (float)square.Val2, linear.Val);
            linearVector = val => new Vector((float)square.Val1, (float)square.Val2, val);
            squareVector = (x, y) => new Vector(x, y, linear.Val);
            replacer = v => new Vector(v.CoordinateZ, v.CoordinateX, v.CoordinateY);
            linear.SetValIn(value.CoordinateZ);
            square.SetValIn(value.CoordinateX, value.CoordinateY);
            linear.ColorCount = 2;
            linear.BrushFunc = () =>
            {
                linear.GetColors()[0] = Hsv.FromHsv(linearVector(1f));
                linear.GetColors()[1] = Hsv.FromHsv(linearVector(0f));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Hsv.FromHsv(new Vector(p.X, p.Y, linear.Val)).GetBrightness();
            };
            square.ColorCount = 2;
            SetColorComponentName(value2, hue1, saturation2);
            linear.Increment = 0.01f;
            square.Increment1 = 1.0 / 360.0;
            square.Increment2 = 0.01;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            squarePointer1.Maximum = 360;
            linearPointer.Maximum = squarePointer2.Maximum = 100;
        }
        void OnHslH()
        {
            tbHex.SwitchSpaceType(HSL);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector(linear.Val, (float)square.Val1, (float)square.Val2);
            linearVector = val => new Vector(val, (float)square.Val1, (float)square.Val2);
            squareVector = (x, y) => new Vector(linear.Val, x, y);
            replacer = v => new Vector(v.CoordinateX, v.CoordinateY, v.CoordinateZ);
            linear.SetValIn(value.CoordinateX);
            square.SetValIn(value.CoordinateY, value.CoordinateZ);
            linear.ColorCount = 7;
            linear.BrushFunc = () =>
            {
                Color[] colors = new Hsl(vector()).GetHueColors();
                Array.Reverse(colors);
                linear.SetColors(colors);
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Hsl.FromHsl(new Vector(linear.Val, p.X, p.Y)).GetBrightness();
            };
            square.ColorCount = 3;
            SetColorComponentName(hue2, saturation1, lightness2);
            linear.Increment = 1f / 360f;
            square.Increment1 = square.Increment2 = 0.01;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            linearPointer.Maximum = 360;
            squarePointer1.Maximum = squarePointer2.Maximum = 100;
        }
        void OnHslS()
        {
            tbHex.SwitchSpaceType(HSL); 
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val1, linear.Val, (float)square.Val2);
            linearVector = val => new Vector((float)square.Val1, val, (float)square.Val2);
            squareVector = (x, y) => new Vector(x, linear.Val, y);
            replacer = v => new Vector(v.CoordinateY, v.CoordinateX, v.CoordinateZ);
            linear.SetValIn(value.CoordinateY);
            square.SetValIn(value.CoordinateX, value.CoordinateZ);
            linear.ColorCount = 2;
            linear.BrushFunc = () =>
            {
                linear.GetColors()[0] = Hsl.FromHsl(linearVector(1f));
                linear.GetColors()[1] = Hsl.FromHsl(linearVector(0f));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Hsl.FromHsl(new Vector(p.X, linear.Val, p.Y)).GetBrightness();
            };
            square.ColorCount = 3;
            SetColorComponentName(saturation2, hue1, lightness2);
            linear.Increment = 0.01f;
            square.Increment1 = 1.0 / 360.0;
            square.Increment2 = 0.01;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            squarePointer1.Maximum = 360;
            linearPointer.Maximum = squarePointer2.Maximum = 100;
        }
        void OnHslL()
        {
            tbHex.SwitchSpaceType(HSL);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val1, (float)square.Val2, linear.Val);
            linearVector = val => new Vector((float)square.Val1, (float)square.Val2, val);
            squareVector = (x, y) => new Vector(x, y, linear.Val);
            replacer = v => new Vector(v.CoordinateZ, v.CoordinateX, v.CoordinateY);
            linear.SetValIn(value.CoordinateZ);
            square.SetValIn(value.CoordinateX, value.CoordinateY);
            linear.ColorCount = 3;
            linear.BrushFunc = () =>
            {
                linear.GetColors()[0] = Hsl.White;
                linear.GetColors()[1] = Hsl.FromHsl(linearVector(0.5f));
                linear.GetColors()[2] = Hsl.Black;
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Hsl.FromHsl(new Vector(p.X, p.Y, linear.Val)).GetBrightness();
            };
            square.ColorCount = 2;
            SetColorComponentName(lightness2, hue1, saturation2);
            linear.Increment = 0.01f;
            square.Increment1 = 1.0 / 360.0;
            square.Increment2 = 0.01;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            squarePointer1.Maximum = 360;
            linearPointer.Maximum = squarePointer2.Maximum = 100;
        }
        void OnRgbR()
        {
            tbHex.SwitchSpaceType(RGB);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector(linear.Val, (float)square.Val2, (float)square.Val1);
            linearVector = val => new Vector(val, (float)square.Val2, (float)square.Val1);
            squareVector = (x, y) => new Vector(linear.Val, y, x);
            replacer = v => new Vector(v.CoordinateX, v.CoordinateZ, v.CoordinateY);
            linear.SetValIn(value.CoordinateX);
            square.SetValIn(value.CoordinateZ, value.CoordinateY);
            linear.ColorCount = 2;
            linear.BrushFunc = () =>
            {
                linear.GetColors()[0] = Rgb.FromRgb(linearVector(1f));
                linear.GetColors()[1] = Rgb.FromRgb(linearVector(0f));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Rgb.FromRgb(new Vector(linear.Val, p.Y, p.X)).GetBrightness();
            };
            square.ColorCount = 2;
            SetColorComponentName(red2, blue1, green2);
            linear.Increment = 1f / 255;
            square.Increment1 = square.Increment2 = 1.0 / 255;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            linearPointer.Maximum = squarePointer1.Maximum = squarePointer2.Maximum = 255;
        }
        void OnRgbG()
        {
            tbHex.SwitchSpaceType(RGB);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val2, linear.Val, (float)square.Val1);
            linearVector = val => new Vector((float)square.Val2, val, (float)square.Val1);
            squareVector = (x, y) => new Vector(y, linear.Val, x);
            replacer = v => new Vector(v.CoordinateY, v.CoordinateZ, v.CoordinateX);
            linear.SetValIn(value.CoordinateY);
            square.SetValIn(value.CoordinateZ, value.CoordinateX);
            linear.ColorCount = 2;
            linear.BrushFunc = () =>
            {
                linear.GetColors()[0] = Rgb.FromRgb(linearVector(1f));
                linear.GetColors()[1] = Rgb.FromRgb(linearVector(0f));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Rgb.FromRgb(new Vector(p.Y, linear.Val, p.X)).GetBrightness();
            };
            square.ColorCount = 2;
            SetColorComponentName(green2, blue1, red2);
            linear.Increment = 1f / 255;
            square.Increment1 = square.Increment2 = 1.0 / 255;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            linearPointer.Maximum = squarePointer1.Maximum = squarePointer2.Maximum = 255;
        }
        void OnRgbB()
        {
            tbHex.SwitchSpaceType(RGB);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val1, (float)square.Val2, linear.Val);
            linearVector = val => new Vector((float)square.Val1, (float)square.Val2, val);
            squareVector = (x, y) => new Vector(x, y, linear.Val);
            replacer = v => new Vector(v.CoordinateZ, v.CoordinateX, v.CoordinateY);
            linear.SetValIn(value.CoordinateZ);
            square.SetValIn(value.CoordinateX, value.CoordinateY);
            linear.ColorCount = 2;
            linear.BrushFunc = () =>
            {
                linear.GetColors()[0] = Rgb.FromRgb(linearVector(1f));
                linear.GetColors()[1] = Rgb.FromRgb(linearVector(0f));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Rgb.FromRgb(new Vector(p.X, p.Y, linear.Val)).GetBrightness();
            };
            square.ColorCount = 2;
            SetColorComponentName(blue2, red1, green2);
            linear.Increment = 1f / 255;
            square.Increment1 = square.Increment2 = 1.0 / 255;
            linearPointer.Minimum = squarePointer1.Minimum = squarePointer2.Minimum = 0;
            linearPointer.Maximum = squarePointer1.Maximum = squarePointer2.Maximum = 255;
        }
        void OnLabL()
        {
            tbHex.SwitchSpaceType(LAB);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector(linear.Val, (float)square.Val1, (float)square.Val2);
            linearVector = val => new Vector(val, (float)square.Val1, (float)square.Val2);
            squareVector = (x, y) => new Vector(linear.Val, x, y);
            replacer = v => new Vector(v.CoordinateX, v.CoordinateY, v.CoordinateZ);
            linear.SetValIn(value.CoordinateX);
            square.SetValIn(value.CoordinateY, value.CoordinateZ);
            linear.ColorCount = 9;
            linear.BrushFunc = () =>
            {
                int n = linear.ColorCount;
                for (int i = 0; i < n; i++) linear.GetColors()[i] = Lab.FromLab(linearVector((float)(n - 1 - i) / n));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Lab.FromLab(new Vector(linear.Val, p.X, p.Y)).GetBrightness();
            };
            square.ColorCount = 5;
            SetColorComponentName(l, a, b);
            linear.Increment = 0.01f;
            square.Increment1 = square.Increment2 = 1.0 / 255;
            linearPointer.Minimum = 0;
            linearPointer.Maximum = 100;
            squarePointer1.Minimum = squarePointer2.Minimum = -128;
            squarePointer1.Maximum = squarePointer2.Maximum = 127;
        }
        void OnLabA()
        {
            tbHex.SwitchSpaceType(LAB);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val2, linear.Val, (float)square.Val1);
            linearVector = val => new Vector((float)square.Val2, val, (float)square.Val1);
            squareVector = (x, y) => new Vector(y, linear.Val, x);
            replacer = v => new Vector(v.CoordinateY, v.CoordinateZ, v.CoordinateX);
            linear.SetValIn(value.CoordinateY);
            square.SetValIn(value.CoordinateZ, value.CoordinateX);
            linear.ColorCount = 9;
            linear.BrushFunc = () =>
            {
                int n = linear.ColorCount;
                for (int i = 0; i < n; i++) linear.GetColors()[i] = Lab.FromLab(linearVector((float)(n - 1 - i) / n));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Lab.FromLab(new Vector(p.Y, linear.Val, p.X)).GetBrightness();
            };
            square.ColorCount = 5;
            SetColorComponentName(a, b, l);
            linear.Increment = 1f / 255;
            square.Increment1 = 1.0 / 255;
            square.Increment2 = 0.01;
            squarePointer2.Minimum = 0;
            squarePointer2.Maximum = 100;
            linearPointer.Minimum = squarePointer1.Minimum = -128;
            linearPointer.Maximum = squarePointer1.Maximum = 127;
        }
        void OnLabB()
        {
            tbHex.SwitchSpaceType(LAB);
            Vector value = VectorSpace.Linear;
            clNew.Space = Space;
            vector = () => new Vector((float)square.Val2, (float)square.Val1, linear.Val);
            linearVector = val => new Vector((float)square.Val2, (float)square.Val1, val);
            squareVector = (x, y) => new Vector(y, x, linear.Val);
            replacer = v => new Vector(v.CoordinateZ, v.CoordinateY, v.CoordinateX);
            linear.SetValIn(value.CoordinateZ);
            square.SetValIn(value.CoordinateY, value.CoordinateX);
            linear.ColorCount = 9;
            linear.BrushFunc = () =>
            {
                int n = linear.ColorCount;
                for (int i = 0; i < n; i++) linear.GetColors()[i] = Lab.FromLab(linearVector((float)(n - 1 - i) / n));
                return linear.UpdatedBrush();
            };
            square.BrightnessUnderTheCursorFunc = loc =>
            {
                PointF p = square.ValsFromLocation(loc);
                return Lab.FromLab(new Vector(p.Y, p.X, linear.Val)).GetBrightness();
            };
            square.ColorCount = 5;
            SetColorComponentName(b, a, l);
            linear.Increment = 1f / 255;
            square.Increment1 = 1.0 / 255;
            square.Increment2 = 0.01;
            squarePointer2.Minimum = 0;
            squarePointer2.Maximum = 100;
            linearPointer.Minimum = squarePointer1.Minimum = -128;
            linearPointer.Maximum = squarePointer1.Maximum = 127;
        }
        void SetColorComponentName(string name1, string name2, string name3)
        {
            lb1.Text = name1;
            lb2.Text = name2;
            lb3.Text = name3;
            lb1.Top = wrapL.Top + (wrapL.Height - lb1.Height) / 2;
            lb2.Left = wrapS.Left + (wrapS.Width - lb2.Width) / 2;
            lb3.Top = wrapS.Top + (wrapS.Height - lb3.Height) / 2;
        }
        void UpdateColorBoxes()
        {
            square.InitBrush();
            square.SelfPaint = false;
            linear.Invalidate();
            square.Invalidate();
        }
        void UpdatePointer()
        {
            squarePointer1.Val = square.Val1;
            squarePointer2.Val = square.Val2;
            linearPointer.Val = linear.Val;
        }
        void SelectKind(RadioButton rb)
        {
            setKind[rb]();
            UpdatePointer();
            UpdateColorBoxes();
            Text = Space.ToString();
        }
        void SetValInColorBoxes()
        {
            Vector values = VectorSpace.Linear;
            Vector input = replacer(values);
            linear.SetValIn(input.CoordinateX);
            square.SetValIn(input.CoordinateY, input.CoordinateZ);
        }
        void SetValIn(IBaseSpace val)
        {
            VectorSpace = val as IVectorSpace;
            Text = val.ToString();
            SetValInColorBoxes();
            clNew.Space = val;
        }
        void HexFocus()
        {
            wrapL.Leave -= wrap_Leave;
            wrapS.Leave -= wrap_Leave;
            tbHex.Focus();
            wrapL.Leave += wrap_Leave;
            wrapS.Leave += wrap_Leave;
        }
        RadioButton GetCheckedRadioButton()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                RadioButton rb = ctrl as RadioButton;
                if (rb != null && rb.Checked) return rb;
            }
            rbHsvH.Checked = true;
            return rbHsvH;
        }
        private void enterHex_Click(object sender, EventArgs e)
        {
            HexFocus();
        }
        private void Rb_LostFocus(object sender, EventArgs e)
        {
            Keys mod = ModifierKeys & Keys.Modifiers;
            if (mod == Keys.Shift) wrapL.Focus();
        }
        private void wrapHex_Leave(object sender, EventArgs e)
        {
            wrapL.Focus();
        }
        private void wrap_Leave(object sender, EventArgs e)
        {
            WrapControl wrap = sender as WrapControl;
            Keys mod = ModifierKeys & Keys.Modifiers;
            if (mod == Keys.Shift) GetCheckedRadioButton().Focus();
            else (wrap == wrapL ? wrapS : wrapL).Focus();
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked) SelectKind(rb);
        }
        private void square_Paint(object sender, PaintEventArgs e)
        {
            int side = (int)square.WX, indent = square.Indent;
            int colorCount = square.ColorCount;
            for (int i = 0; i <= side; i++)
            {
                for (int j = 0; j < colorCount; j++)
                    square.GetColors()[j] = VectorSpace.FromSpace(squareVector((float)i / side, (float)j / (colorCount - 1)));
                e.Graphics.FillRectangle(square.UpdatedBrush(), i + indent, indent, 1, side);
            }
        }
        private void square_ValueChanged(object sender, EventArgs e)
        {
            linear.Invalidate();
            squarePointer1.Val = square.Val1;
            squarePointer2.Val = square.Val2;
            NewSpace();
        }
        private void linear_ValueChanged(object sender, EventArgs e)
        {
            square.Invalidate();
            linearPointer.Val = linear.Val;
        }
        private void DialogForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                clOld.Space = Space;
                SelectKind(GetCheckedRadioButton());
                SetValIn(Space);
                wrapL.Focus();
            }
        }
        private void DialogForm_Shown(object sender, EventArgs e)
        {
            linear.ValueChanged += linear_ValueChanged;
            square.ValueChanged += square_ValueChanged;
        }
        private void tbHex_MouseDown(object sender, MouseEventArgs e)
        {
            HexFocus();
        }
        private void square_ValueChanged1(object sender, EventArgs e)
        {
            linear.Invalidate();
            squarePointer1.Val = square.Val1;
            NewSpace();
        }
        private void square_ValueChanged2(object sender, EventArgs e)
        {
            linear.Invalidate();
            squarePointer2.Val = square.Val2;
            NewSpace();
        }
    }
}

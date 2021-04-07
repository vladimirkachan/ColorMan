using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

[assembly: CLSCompliant(true)]
namespace ColorMan.ExtensionLibrary
{
    public static class Extension
    {
        public static string AppDataLocalFolder { get; private set; }

        public static int CutRange(this int arg, int min, int max)
        {
            return arg < min ? min : arg > max ? max : arg;
        }
        public static float CutRange(this float arg, float min, float max)
        {
            return float.IsNaN(arg) || arg < min ? min : arg > max ? max : arg;
        }
        public static double CutRange(this double arg, double min, double max)
        {
            return double.IsNaN(arg) || arg < min ? min : arg > max ? max : arg;
        }
        public static float LinearToRange(this float linear, float min, float max)
        {
            float range = max - min;
            return min + linear * range;
        }
        public static Color Invert(this Color color)
        {
            return Color.FromArgb(color.R ^ byte.MaxValue, color.G ^ byte.MaxValue, color.B ^ byte.MaxValue);
        }
        public static Color AverageColor(this Color[][] colors)
        {
            double r = 0d, g = 0d, b = 0d;
            int sum = 0;
            foreach (var t in colors)
            {
                int len = t.Length;
                sum += len;
                for (int x = 0; x < len; x++)
                {
                    Color c = t[x];
                    r += c.R;
                    g += c.G;
                    b += c.B;
                }
            }
            return Color.FromArgb((int)Math.Round(r / sum, MidpointRounding.AwayFromZero),
                                  (int)Math.Round(g / sum, MidpointRounding.AwayFromZero),
                                  (int)Math.Round(b / sum, MidpointRounding.AwayFromZero));
        }
        public static Point ScreenLocation(this Control ctrl)
        {
            if (ctrl.Parent == null) return ctrl.Location;
            for (Point p = Point.Empty; ; ctrl = ctrl.Parent)
            {
                Form f = ctrl.Parent as Form;
                if (f != null)
                {
                    p += new Size(f.PointToScreen(ctrl.Location));
                    return p;
                }
                p += new Size(ctrl.Location);
            }
        }
        public static Size Multiply(this Size size, double multiplier)
        {
            return new Size((int)Math.Round(size.Width * multiplier, MidpointRounding.AwayFromZero),
                (int)Math.Round(size.Height * multiplier, MidpointRounding.AwayFromZero));
        }
        public static Size Divide(this Size size, double divider)
        {
            return new Size((int)Math.Round(size.Width / divider, MidpointRounding.AwayFromZero),
                (int)Math.Round(size.Height / divider, MidpointRounding.AwayFromZero));
        }
        public static Size Invert(this Size size)
        {
            return new Size(size.Height, size.Width);
        }
        public static Bitmap NewBitmap(this Size size)
        {
            return new Bitmap(size.Width, size.Height);
        }
        public static string GetNextFileName(this FileDialog sfd, string snippet)
        {
            string name;
            for (int i = 1; ; i++)
            {
                name = snippet + i;
                string f = sfd.InitialDirectory + "\\" + name + "." + sfd.DefaultExt;
                if (!File.Exists(f)) break;
            }
            sfd.FileName = name;
            return name;
        }
        public static bool SetMousePosition(int posX, int posY)
        {
            return NativeMethods.SetCursor(posX, posY);
        }
        public static Control AlignByCenter(this Control ctrl)
        {
            Control parent = ctrl.Parent;
            if (parent != null) ctrl.Location = new Point((parent.ClientSize - ctrl.Size).Divide(2));
            return ctrl;
        }
        public static void RecycleFile(string path)
        {
            if (File.Exists(path))
                FileSystem.DeleteFile(path, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }
        public static void RegistryWrite(string subkey, string name, object value)
        {
            using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(subkey))
            {
                if (rk == null) return;
                rk.SetValue(name, value);
            }
        }
        public static void RegistryWrite(string subkey, Dictionary<string, object> branchData)
        {
            using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(subkey))
            {
                if (rk == null) return;
                foreach (var data in branchData) rk.SetValue(data.Key, data.Value);
            }
        }
        public static object RegistryRead(string subkey, string name)
        {
            using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(subkey)) return rk == null ? null : rk.GetValue(name);
        }
        public static Dictionary<string, object> RegistryRead(string subkey, IEnumerable<string> names)
        {
            using (RegistryKey rk = Registry.CurrentUser.CreateSubKey(subkey))
            {
                if (rk == null) return null;
                Dictionary<string, object> branchData = new Dictionary<string, object>();
                foreach (var name in names)
                {
                    var value = rk.GetValue(name);
                    if (value == null) continue;
                    branchData[name] = value;
                }
                return branchData;
            }
        }
        public static void AppRegistryWrite(string appRegKey)
        {
            AppDataLocalFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Hkey.ColorMan;
            if (!Directory.Exists(AppDataLocalFolder)) Directory.CreateDirectory(AppDataLocalFolder);
            RegistryWrite(Hkey.RootKey, Hkey.AppDataLocalFolder, AppDataLocalFolder);
            RegistryWrite(appRegKey, Hkey.ExecutablePath, Application.ExecutablePath);
        }

    }
}

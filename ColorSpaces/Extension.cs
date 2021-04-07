
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace ColorMan.ColorSpaces
{
	public static class Extension
	{
	    static readonly Collection<Color> webColors = InitializeColors();
	    static readonly HashSet<string> webColorNames = InitializeNames();
	    static readonly Dictionary<string, Color> webColorbyHex = InitializeColorsByHex();
        public static Collection<Color> WebColors { get { return webColors; } }
	    static Collection<Color> InitializeColors()
	    {
	        var collection = new Collection<Color>();
	        foreach (var property in typeof(Color).GetProperties(BindingFlags.Public | BindingFlags.Static))
                collection.Add((Color)property.GetValue(null, null));
            collection.Remove(Color.Transparent);
	        return collection;
	    }
	    static HashSet<string> InitializeNames()
	    {
	        var names = new HashSet<string>();
            foreach (Color c in webColors) names.Add(c.Name.ToUpperInvariant());
            return names;
	    }
	    static Dictionary<string, Color> InitializeColorsByHex()
	    {
	        var dictionary = new Dictionary<string, Color>();
            foreach (Color c in webColors) dictionary[c.ToHex()] = c;
            return dictionary;
	    }
	    public static bool IsWebColor(this string name)
        {
            return webColorNames.Contains(name.ToUpperInvariant());
        }
        public static bool IsWebColor(this IBaseSpace space)
        {
            return webColorbyHex.ContainsKey(space.Hex);
        }
        public static bool IsWebColor(this Color color)
        {
            return webColorbyHex.ContainsKey(color.ToHex());
        }
        public static Color NearestWebColor(this Color color)
        {
            string hex = color.ToHex();
            if (webColorbyHex.ContainsKey(hex)) return webColorbyHex[hex];
            Color nearest = Color.Empty;
            double d = 500.0;
            double r = color.R, g = color.G, b = color.B;
            foreach (Color c in webColors)
            {
                double x = Math.Sqrt(Math.Pow(r - c.R, 2) + Math.Pow(g - c.G, 2) + Math.Pow(b - c.B, 2));
                if (x < d)
                {
                    d = x;
                    nearest = c;
                }
            }
            return nearest;
        }
        public static Cursor CreateCursor(this IBaseSpace space)
        {
            return new Cursor(CreateColorBitmap(space).GetHicon());
        }
        static Bitmap CreateColorBitmap(IBaseSpace space)
        {
            Bitmap bmp = new Bitmap(18, 18);
            int a = 17;
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.FillEllipse(Brushes.Black, 0, 0, a, a);
                gr.FillEllipse(Brushes.White, 2, 2, a - 4, a - 4);
                gr.FillEllipse(new SolidBrush(space.ToColor()), 3, 3, a - 6, a - 6);
            }
            return bmp;
        }
        public static string ToHex(this Color color)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0:x2}{1:x2}{2:x2}", color.R, color.G, color.B);
        }
        /// <summary>
        /// Преобразует строковое представление HEX (XXX или XXXXXX) в эквивалентное значение
        /// System.Drawing.Color
        /// </summary>
        /// <param name="hex">XXX или XXXXXX</param>
        /// <returns>System.Drawing.Color</returns>
        public static Color ToColor(this string hex)
        {
            int len = hex.Length;
            if (len == 3) hex = hex[0].ToString() + hex[0] + hex[1] + hex[1] + hex[2] + hex[2];
            else if (len != 6) throw new ArgumentException(hex);
            int r = int.Parse(hex.Substring(0, 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture),
                    g = int.Parse(hex.Substring(2, 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture),
                    b = int.Parse(hex.Substring(4, 2), NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
            return Color.FromArgb(r, g, b);
        }
	}
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMan.ExtensionLibrary
{
    public static class LocalScreen
    {
        public static int Width { get; private set; }
        public static int Height { get; private set; }
        public static Size Size { get; private set; }
        public static int AllWidth { get; private set; }
        public static int AllHeight { get; private set; }
        public static Size AllSize { get; private set; }

        static LocalScreen()
        {
            Rectangle primaryScreen = Screen.PrimaryScreen.Bounds;
            Width = primaryScreen.Width;
            AllHeight = Height = primaryScreen.Height;
            Size = primaryScreen.Size;
            foreach (var screen in Screen.AllScreens)
            {
                var bounds = screen.Bounds;
                AllWidth += bounds.Width;
                AllHeight = Math.Max(AllHeight, bounds.Height);
            }
            AllSize = new Size(AllWidth, AllHeight);
        }

        public static Form TopLeft(this Form form)
        {
            form.Location = Point.Empty;
            return form;
        }
        public static Form TopCenter(this Form form)
        {
            form.Location = new Point((Width - form.Width) / 2, 0);
            return form;
        }
        public static Form TopRight(this Form form)
        {
            form.Location = new Point(Width - form.Width, 0);
            return form;
        }
        public static Form MiddleLeft(this Form form)
        {
            form.Location = new Point(0, (Height - form.Height) / 2);
            return form;
        }
        public static Form MiddleCenter(this Form form)
        {
            form.Location = new Point((Width - form.Width) / 2, (Height - form.Height) / 2);
            return form;
        }
        public static Form MiddleRight(this Form form)
        {
            form.Location = new Point(Width - form.Width, (Height - form.Height) / 2);
            return form;
        }
        public static Form BottomLeft(this Form form)
        {
            form.Location = new Point(0, Height - form.Height);
            return form;
        }
        public static Form BottomCenter(this Form form)
        {
            form.Location = new Point((Width - form.Width) / 2, Height - form.Height);
            return form;
        }
        public static Form BottomRight(this Form form)
        {
            form.Location = new Point(Width - form.Width, Height - form.Height);
            return form;
        }
        public static Form Offset(this Form form, int deltaX, int deltaY)
        {
            form.Location = form.Location + new Size(deltaX, deltaY);
            return form;
        }
        public static Control ToScreenBounds(this Control ctrl)
        {
            if (ctrl.Left < 0) ctrl.Left = 0;
            if (ctrl.Right > Width) ctrl.Left = Width - ctrl.Width;
            if (ctrl.Top < 0) ctrl.Top = 0;
            if (ctrl.Bottom > Height) ctrl.Top = Height - ctrl.Height;
            return ctrl;
        }
        public static Point ToScreenBounds(this Point point)
        {
            int x = point.X, y = point.Y;
            x = x < 0 ? 0 : x > Width ? Width : x;
            y = y < 0 ? 0 : y > Height ? Height : y;
            return new Point(x, y);
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace ColorMan.ExtensionLibrary
{
    public static class NativeMethods
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool SetForeground(IntPtr handle)
        {
            return SetForegroundWindow(handle);
        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool SetCursor(int posX, int posY)
        {
            return SetCursorPos(posX, posY);
        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetCursorPos(int X, int Y);
    }
}

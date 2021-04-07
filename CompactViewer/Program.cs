using System;
using System.Windows.Forms;
using CommonExtension = ColorMan.ExtensionLibrary.Extension;

namespace ColorMan.CompactViewer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CommonExtension.AppRegistryWrite(CompactViewerForm.AppRegKey);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CompactViewerForm());
        }
    }
}

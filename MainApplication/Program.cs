using System;
using System.IO;
using System.Windows.Forms;
using ColorMan.ExtensionLibrary;
using CommonExtension = ColorMan.ExtensionLibrary.Extension;

[assembly: CLSCompliant(true)]
namespace ColorMan
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CommonExtension.AppRegistryWrite(MainForm.AppRegKey);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

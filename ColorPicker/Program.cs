using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ColorMan.ExtensionLibrary;
using CommonExtension = ColorMan.ExtensionLibrary.Extension;

namespace ColorMan.ColorPicker
{
    static class Program
    {
        static bool created;
        static readonly Mutex mutex = new Mutex(true, Hkey.ColorPicker, out created);
        const string ProcessId = "ProcessId";
        public const string MFN = "mutexhash.txt";
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CommonExtension.AppRegistryWrite(ColorPickerForm.AppRegKey);

            if (!created)
            {
                object obj = CommonExtension.RegistryRead(ColorPickerForm.AppRegKey, ProcessId);
                if (obj != null)
                {
                    var process = Process.GetProcessById((int)obj);
                    if (File.Exists(MFN)) File.Delete(MFN);
                    process.Kill();
                }
            }
            CommonExtension.RegistryWrite(ColorPickerForm.AppRegKey, ProcessId, Process.GetCurrentProcess().Id);
            using (var streamWriter = File.CreateText(MFN)) streamWriter.WriteLine(mutex.GetHashCode());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ColorPickerForm());
        }
    }
}

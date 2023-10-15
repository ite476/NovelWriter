using NovelWriter.Module;
using NovelWriter.Windows.Main;
using System.Diagnostics;

namespace NovelWriter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            App.Instance.Settings.Init();
            Application.Run(new MainForm());
        }
    }
}
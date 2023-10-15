using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelWriter.Module
{
    partial class FileWriter_NW
    {
        private string GetFileName_Directorized(string targetName, string fileExtension) => $@"\{GetFileName(targetName)}.{fileExtension}";
        private string GetFileName(string targetName) => $"Novel_Dear{targetName}";
        private string GetPath_DirectoryAndFile(string saveDirectory, string targetName, string fileExtension) => GetPath_DirectoryAndFile(saveDirectory, GetFileName_Directorized(targetName, fileExtension));
        private string GetPath_DirectoryAndFile(string saveDirectory, string directorizedFilename) => saveDirectory + directorizedFilename;


        private void CreateDirectory_IfNeeded(string SaveDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(SaveDirectory);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }


        void references()
        {
            var startupDir = Application.StartupPath;
            var folder = Environment.SpecialFolder.ApplicationData;
            var theDirectory = Environment.GetFolderPath(folder);
            MessageBox.Show(theDirectory);
            Process.Start("explorer.exe", theDirectory);
        }
    }
}

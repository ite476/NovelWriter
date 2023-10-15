using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace NovelWriter.Module
{
    public partial class FileWriter_NW
    {
        public string SaveFolder { get; set; } = Application.StartupPath;

        public bool WriteJson<T>(T data, string targetName, string fileExtension = "txt") => WriteJson(data, SaveFolder, targetName, fileExtension);
        public bool WriteJson<T>(T data, string folderDirectory, string targetName, string fileExtension)
        {
            if (targetName == string.Empty) { targetName = "Sample"; }

            string jsonString = JsonSerializer.Serialize(data);            
            
            CreateDirectory_IfNeeded(folderDirectory);

            string path = GetPath_DirectoryAndFile(folderDirectory, targetName, fileExtension);
            File.WriteAllText(path, jsonString);

            return true;
        }

        public T? ReadFile<T>(string targetName, string fileExtension = "txt") => ReadFile<T>(SaveFolder, targetName, fileExtension);
        public T? ReadFile<T>(string folderDirectory, string targetName, string fileExtension)
        {
            if (targetName == string.Empty) { targetName = "Sample"; }

            T? data = default;

            try
            {
                CreateDirectory_IfNeeded(folderDirectory);

                string path = GetPath_DirectoryAndFile(folderDirectory, targetName, fileExtension);
                string jsonString = File.ReadAllText(path);
                data = JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            

            return data;
        }


    }
}

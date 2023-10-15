using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelWriter.Module
{
    public class AppSettings
    {
        public AppSettings() {           

        }

        public void Init()
        {
            var data = App.Instance.File.ReadFile<Dictionary<string, string>>(Application.StartupPath, "Settings", "ini");

            if (data == null)
            {
                data = GetDirectory_StartupPath_AndCreateFile();
            }
            
            App.Instance.File.SaveFolder = data["SaveDirectory"];
        }


        public void ChangeDirectory(string directory)
        {
            var data = new Dictionary<string, string>();
            data["SaveDirectory"] = directory;

            App.Instance.File.SaveFolder = directory;
            App.Instance.File.WriteJson(data, Application.StartupPath, "Settings", "ini");
        }


        private Dictionary<string, string> GetDirectory_StartupPath_AndCreateFile()
        {
            Dictionary<string, string>? data = new Dictionary<string, string>()
                {
                    { "SaveDirectory", Application.StartupPath }
                };
            WriteSettings_ini(data);
            return data;
        }

        private void WriteSettings_ini(Dictionary<string, string> data) => App.Instance.File.WriteJson(data, Application.StartupPath, "Settings", "ini");

        
    }
}

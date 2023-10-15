using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelWriter.Module
{ 
    /// <summary>
    /// 싱글톤 객체 관리용
    /// </summary>
    public class App
    {
        public static App? _Instance = null;
        static public App Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new App();
                }
                return _Instance;
            }
        }

        public FileWriter_NW File { get; }
        public AppSettings Settings { get; }
        public App()
        {
            File = new FileWriter_NW();
            Settings = new AppSettings();
        }
    }
}

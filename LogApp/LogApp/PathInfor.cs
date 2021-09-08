using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApp
{
    class PathInfor
    {
        public PathInfor(string pStart, string pEnd) { Purpose = pStart; origin = pEnd; }
        public string Purpose { get; set; }//目標(最新)
        public string origin { get; set; }//來源(txt)
        public string _PATH { get; set; } = System.Windows.Forms.Application.StartupPath + "\\Setting.txt";
        public PathInfor() {
            if (File.Exists(_PATH))
            {
                string line;
                int counter = 0;
                StreamReader stream = new StreamReader(_PATH);
                while ((line = stream.ReadLine()) != null)
                {
                    switch (counter)
                    {
                        case 0: Purpose = line; break;
                        case 1: origin = line; break;
                    }
                    counter++;
                }
                stream.Close();
            }
        }
        public PathInfor(string path) {
            _PATH = path;
            if (File.Exists(path))
            {
                string line;
                int counter = 0;
                StreamReader stream = new StreamReader(path);
                while ((line = stream.ReadLine()) != null)
                {
                    switch (counter)
                    {
                        case 0: Purpose = line; break;
                        case 1: origin = line; break;
                    }
                    counter++;
                }
                stream.Close();
            }
        }
        public void Set_SetLog(string str)
        {
            if(_PATH != null && File.Exists(_PATH))
            {
                File.WriteAllText(_PATH, str);
            }
        }
        private string Get_NewVersion(DateTime dt)
        {
            return dt.ToString("MM") + dt.ToString("dd") + "." + dt.ToString("HH") + dt.ToString("mm");
        }

        public string Get_Version(string sType)
        {
            if (!File.Exists(_PATH)) { File.AppendText(_PATH); }
            string Result="";
            switch (sType.ToUpper())
            {
                case "NEW":
                    Result = File.Exists(Purpose)
                        ? Get_NewVersion(File.GetLastWriteTime(Purpose)) : "";
                    return Result;
                case "NOW":
                    Result = File.Exists(origin)
                        ? new StreamReader(origin).ReadLine() : "";
                    return Result;
            }
            return Result;
        }

    }
}

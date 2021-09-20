using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApp
{
    class PathInfor
    {
        public PathInfor(string pStart, string pEnd) { Purpose = pStart; Origin = pEnd; }
        public string Folder { get; set; }//資料夾
        public string Origin { get; set; }//來源(txt)
        public string Purpose { get; set; }//目標(最新)
        public string Origin_Folder { get; set; }//來源(資料夾)
        public string Purpose_Folder { get; set; }//目標(資料夾)
        public string Run_Timer { get; set; } = "0";
        public string _PATH { get; set; } = System.Windows.Forms.Application.StartupPath + "\\Setting.dat";
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
                        case 0: Folder = line; break;
                        case 1: Origin = line; break;
                        case 2: Purpose = line; break;
                        case 3: Origin_Folder = line; break;
                        case 4: Purpose_Folder = line; break;
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
                        case 1: Origin = line; break;
                        case 2: Folder = line; break;
                        case 3: Origin_Folder = line; break;
                        case 4: Purpose_Folder = line; break;
                    }
                    counter++;
                }
                stream.Close();
            }
        }

        /// <summary>
        /// 設定Log設定檔案
        /// </summary>
        /// <param name="str"></param>
        public void Set_SetLog(string str)
        {
            if(_PATH != null && File.Exists(_PATH))
            {
                File.WriteAllText(_PATH, str);
            }
        }

        /// <summary>
        /// 取得版號格式
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string Get_NewVersion(DateTime dt)
        {
            return dt.ToString("MM") + dt.ToString("dd") + "." + dt.ToString("HH") + dt.ToString("mm");
        }

        /// <summary>
        /// 取得版號
        /// </summary>
        /// <param name="sType"></param>
        /// <returns></returns>
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
                    if (File.Exists(Origin))
                    {
                        using (StreamReader sr = new StreamReader(Origin))
                        {
                            Result = sr.ReadLine();
                            sr.Close();
                        }
                    }
                    return Result;
            }
            return Result;
        }


        private FileInfo[] GetFileList(string path)
        {
            FileInfo[] fileList = null;
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                fileList = di.GetFiles();
            }
            return fileList;
        }
        private DirectoryInfo[] GetDirsList(string path)
        {
            DirectoryInfo[] DirsList = null;
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                DirsList = di.GetDirectories();
            }
            return DirsList;
        }
        /// <summary>
        ///  複製檔案
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs">是否複製子目錄</param>
        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            Stopwatch timer = new Stopwatch();
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "此目錄不存在或找不到: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            //如果有存在的檔案，就會把他先刪除
            if (Directory.Exists(destDirName))
            {
                Directory.Delete(destDirName,true);
            }
            Directory.CreateDirectory(destDirName);
            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            //如果複製子目錄，請將它們及其內容複製到新位置
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        public void DirectoryFileCopy(string removeDir, string desDir, bool copySubDirs)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            DirectoryCopy(removeDir, desDir ,  copySubDirs);
            Run_Timer = timer.ElapsedMilliseconds.ToString();
            timer.Stop();
        }
    }
}

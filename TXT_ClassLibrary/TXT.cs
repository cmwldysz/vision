using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXT_ClassLibrary
{
    public class TXT
    {
        public static string logPath = "";
        static TXT() {
            string temp = DateTime.Now.ToString(string.Format("{0}{1}{2}{3}{4}{5}", 
                DateTime.Now.Year, DateTime.Now.Month, 
                DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
            logPath = string.Format(@"D:\work\log\{0}.txt", temp);
        }
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path">文件地址</param>
        /// <param name="str">写入内容</param>
        public static void write_txt(string path,string str) {
            StreamWriter sw = new StreamWriter(logPath, true);
            sw.WriteLine(str);
            sw.Close();
        }
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string read_txx(string path) {
            StreamReader sr = new StreamReader(logPath);
            string str = sr.ReadToEnd();
            sr.Close();
            return str;
        }
    }
}

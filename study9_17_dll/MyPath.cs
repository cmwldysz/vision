using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace study9_17_dll
{
    public class MyPath
    {
        //1.用用空间：using System.Runtime.InteropServices;
        //2.指定动态链接库：指定DLL的位置（在系统路径中/在当前EXE下/指定路径）
        [DllImport("kernel32.dll", SetLastError = true)]//引用c++动态链接数据库       
        public static extern int GetCurrentDirectory(int BufSize, StringBuilder buf);

        [DllImport("kernel32.dll", SetLastError = true)]//引用c++动态链接数据库
        public static extern bool RemoveDirectory(string name);
    }
}

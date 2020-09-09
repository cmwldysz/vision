using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace My_Second
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数
            int p = 3;
            //浮点数/小数
            double s = 3.14;
            //字符串类型
            string str = "超人视觉";
            // 字节
            char c = 'a';
            //隐式转换
            double D = p;
            //显示转换（强制类型转换）
            int S = (int)D;
            int SW = (int)3.14;
            //输出内容
            Console.WriteLine(str);
            Console.WriteLine(D);
            Console.WriteLine(SW);
            Console.ReadLine();
        }
    }
}

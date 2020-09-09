using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first
{
    class Program
    {
        static void Main(string[] args)
        {
            //我的第一个程序
            Console.WriteLine("请输入你的名称：");
            string name = Console.ReadLine();
            Console.WriteLine("你好：" + name);
            Console.WriteLine("试一下占位符：{0}", "%");
            Console.ReadLine();
        }
    }
}

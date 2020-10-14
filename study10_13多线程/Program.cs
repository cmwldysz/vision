using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_13多线程
{
    class Program
    {
        static void pMain(string[] args)
        {
            Console.WriteLine("主线：开始。。。");
            Thread.Sleep(5000);
            Console.WriteLine("主线程：结束！");
            Console.ReadKey();
        }
    }
}

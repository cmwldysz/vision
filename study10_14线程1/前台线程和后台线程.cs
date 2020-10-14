using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_14线程1
{
    class 前台线程和后台线程
    {
        static void Main(string[] args)
        {
            Console.Write("主线程开始:");
            Thread t1 = new Thread(NoramlWork);//前台线程
            t1.Start();
            Thread t2 = new Thread(BackgroundWork);//后台线程
            t2.IsBackground = true; t2.Start();
            Console.ReadKey();
        }
        public static void NoramlWork()
        {
            Console.Write("前台线程开始：");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("N"); Thread.Sleep(100);
            }
            Console.Write("前台线程结束。");
        }
        public static void BackgroundWork()
        {
            Console.Write("后台线程开始：");
            while (true)
            {
                Console.Write("B"); Thread.Sleep(100);
            }
            Console.Write("后台线程结束。");
        }
    }
}

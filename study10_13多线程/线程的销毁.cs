using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_13多线程
{
    class 线程的销毁
    {
        static void pMain() {
            Console.WriteLine("主线程开始");
            Thread t = new Thread(DoWork);
            t.Start();
            Thread.Sleep(1000);
            Console.WriteLine("主线程试图销毁工作线程。");
            t.Abort();
            t.Join();
            Console.WriteLine("工作线程终止，主线程终止");
            Console.ReadKey();
        }
        public static void DoWork() {
            try
            {
                while (true)
                {
                    Console.Write("t");
                    Thread.Sleep(100);
                }
            }
            catch (ThreadAbortException abort)
            {
                Console.WriteLine("工作线程被{0}终止。",(string)abort.ExceptionState);
            }
        }
    }
}

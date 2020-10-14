using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_14线程1
{
    class 同步事件和等待句柄
    {
        //同步事件
        private static AutoResetEvent walthandle = new AutoResetEvent(false);
        static void pMain() {
            Console.WriteLine("主线程开始");
            Thread t = new Thread(DoWork);
            t.Start();
            walthandle.WaitOne();//等待WaitOne
            Console.WriteLine("主线程结束");
            Console.ReadKey();
        }
        public static void DoWork() {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            walthandle.Set();//设置WaitHandle
            Console.WriteLine();
        }
    }
}

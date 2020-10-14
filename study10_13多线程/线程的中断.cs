using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_13多线程
{
    class 线程的中断
    {
        static void pMain() {
            Console.Write("主线程开始");
            Thread t = new Thread(DoWork);
            t.Start();
            Console.WriteLine("请在100秒内按任意键中断线程！");

            Console.ReadKey();
            t.Interrupt();//发出中断工作线程的命令
            t.Join();//使用join方法阻塞当前线程，等待工作线程完成销毁
            Console.WriteLine("主线程结束");
            Console.ReadKey();
        }
        public static void DoWork() {
            Console.WriteLine("工作线程开始");
            try
            {
                Console.WriteLine("工作线程准备休眠100秒...");
                Thread.Sleep(100*1000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("睡眠中断");
            }
        }
    }
}

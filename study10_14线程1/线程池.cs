using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_14线程1
{
    class 线程池
    {
        public static void DoWork(object state)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}-{1}", state.ToString(), i);
                Thread.Sleep(100);//模拟实际操作
            }
        }

        static void pMain(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, "线程" + i);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_15线程Mutex同步
{
    class 并行处理Parallel
    {
        public static void DoWork1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("1-{0}", i);
                Thread.Sleep(100);
            }
        }
        public static void DoWork2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("2-{0}", i);
                Thread.Sleep(100);
            }
        }
        static void pMain() {
            Parallel.Invoke(DoWork1, DoWork2);
            Console.ReadKey();
        }
    }
}

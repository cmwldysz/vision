using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10_15线程Mutex同步
{
    class 显示创建和运行任务
    {
        static void pMain()
        {
            Task taskA = new Task(() => Console.WriteLine("Hello From TaskA"));
            taskA.Start();
            Task taskB = new Task(() => Console.WriteLine("Hello From TaskB"));
            Task taskC = new Task(() => Console.WriteLine("Hello From TaskC"));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_15线程Mutex同步
{
    class Task常用操作
    {
         static Task taskA = new Task(()=> {
            Console.WriteLine("taskA开始...");
            Thread.Sleep(5000);//模拟工作过程
        });
        static void pMain() {
            //启动
            taskA.Start();
            //执行完成后的任务
            taskA.ContinueWith((t) =>
            {
                Console.WriteLine("任务完成，完成时候的状态为：");
                Console.WriteLine("isCanceled={0},isCompleted={1},isFaulted={2}",t.IsCanceled,t.IsCompleted,t.IsFaulted);
            });
            Console.ReadKey();
        }
    }
}

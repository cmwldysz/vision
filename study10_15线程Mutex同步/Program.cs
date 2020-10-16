using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_15线程Mutex同步
{
    class Program
    {
        static void pMain(string[] args)
        {
            //创建命名Mutex，只能存在一个名为MyMutex的系统对象
            Mutex m = new Mutex(false,"Mynutex");
            //试图获取对命名Mutex的控制权，若命名mutex被另一个线程控制，则等待其被释放
            Console.WriteLine("等待myMutex...");
            m.WaitOne();
            //保存对mutex的控制，直至用户按下回车键
            Console.WriteLine("本应用程序拥有MyMutex.请按任意键释放并退出");
            Console.ReadKey();
        }
    }
}

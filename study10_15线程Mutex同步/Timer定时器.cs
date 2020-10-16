using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_15线程Mutex同步
{
    class Timer定时器
    {
        public static void PrintTime(object state) {
            Console.WriteLine("{0} {1}",state.ToString(),DateTime.Now.ToString("HH:mm:ss"));
        }
        static void pMain() {
            TimerCallback timerCallback = new TimerCallback(PrintTime);
            //实例化定时器
            Timer timer1 = new Timer(timerCallback,"timer1",0,1000);
            //卡屏显示
            Console.ReadKey();
            timer1.Dispose();
            Console.ReadKey();
        }
    }
}

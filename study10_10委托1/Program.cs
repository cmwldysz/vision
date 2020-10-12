using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_10委托1
{
    //声明委托
    delegate int MyDelegate(int op1, int op2, out int result);

    class Program
    {
        static int Add(int op1, int op2, out int result)
        {
            Thread.Sleep(5000);//睡眠5秒，模拟实际耗时操作
            return (result = op1 + op2);
        }
        static void Main(string[] args)
        {
            int result;
            MyDelegate d = Add;
            Console.WriteLine("委托异步调用方法开始：");
            IAsyncResult iar = d.BeginInvoke(123, 456, out result, null, null);
            Console.Write("执行其他操作");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Console.WriteLine("等待");
            //使用IAsyncResult.AsyncWaltHandle获取WaltHandle，使用WaitOne方法执行
            //阻塞等待，异步完成之时会发出WaltHandle信号，可通过WaitOne等待
            iar.AsyncWaitHandle.WaitOne();
            Console.WriteLine("异步调用AsyncDelegate.Add()方法结束");
            //EndInvoke方法：若异步调用未完成，EndInvoke将一直阻塞到异步调用完成
            d.EndInvoke(out result, iar);

            Console.WriteLine("异步委托结束：{0}", result);
            Console.ReadKey();
        }
    }
}

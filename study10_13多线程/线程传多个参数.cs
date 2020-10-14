using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_13多线程
{
    //通过对象完成线程传参
    public class ThreadTest {
        private string str1;
        private string str2;

        public string Str1 { get => str1; set => str1 = value; }
        public string Str2 { get => str2; set => str2 = value; }
        public ThreadTest(string a, string b) {
            this.Str1 = a;
            this.Str2 = b;
        }
        public void ThreadProc() {
            Console.WriteLine(Str1+Str2);
        }
    }
    class 线程传多个参数
    {
        static void Main() {
            //通过对象完成传参
            ThreadTest tt = new ThreadTest("Hello ","world");
            Thread thread = new Thread(new ThreadStart(tt.ThreadProc));
            thread.Start();
            string str1 = "hell0 ";
            string str2 = "world";
            Thread thread1 = new Thread(() => DoWork(str1,str2));
            thread1.Start();

            Console.ReadKey();
        }
        static void DoWork(string str1,string str2) {
            Console.WriteLine(str1+str2);
        }
    }
}

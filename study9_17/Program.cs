using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using study9_17_dll;//引用外部方法
using System.Collections.Generic;//迭代器

namespace study9_17
{
    //方法的重载
    class OverLoadExample
    {
        public void SamleMothod(double i)
        {
            Console.WriteLine("SamleMothod(double i):{0}", i);
        }
        public void SamleMothod(int i)
        {
            Console.WriteLine("SamleMothod(int i):{0}", i);
        }

        public void SamleMothod(ref int i)
        {
            Console.WriteLine("SamleMothod(ref int i):{0}", i);
        }
        //ref 和 out 不能同时出现
        //public void SamleMothod(out int i){}
    }
    //递归
    class RecursionTest {
        public static int factorial(int n) {
            if (n <= 1)
            {
                return 1;
            }
            else {
                return factorial(n-1)*n;
            }
        }
     }
    //属性：通过get访问器将秒转换为小时，通过set访问器将每小时转换为秒
    class TimePeriod
    {
        private double seconds;
        public double Hours {
            get { return seconds / 3600; }//转换成小时
            set {
                if (value > 0)
                {
                    seconds = value * 3600;//小时转换成秒
                }
                else {
                    Console.WriteLine("Hours的值不能为负数");
                }
            }
        }

    }
    //静态构造函数
    public class Bus {
        static Bus() {
            Console.WriteLine("调用静态构造函数Bus()");
        }
        public static void Drive()
        {
            Console.WriteLine("调用静态的方法Bus.Drive()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================方法的重载================");
            OverLoadExample Over = new OverLoadExample();
            int i = 10;double d = 11.1;
            Over.SamleMothod(i);
            Over.SamleMothod(d);
            Over.SamleMothod(ref i);
            Console.WriteLine("=================外部方法================");
            //引入了study9_17_dll类库
            StringBuilder sb = new StringBuilder(255);
            MyPath.GetCurrentDirectory(255, sb);
            Console.WriteLine(sb.ToString()) ;

            Console.WriteLine("=================递归================");
            for (int j = 5; j <=10 ; j++)
            {
                Console.Write("{0}!={1}\n",j, RecursionTest.factorial(j));
            }

            Console.WriteLine("=================迭代器方法================");
            foreach (int item in Fibs())
            {
                if (item < 1000)
                {
                    Console.Write("{0}\t", item);
                }
                else {
                    break;
                }
            }

            Console.WriteLine("=================属性================");
            TimePeriod t = new TimePeriod();
            t.Hours = -6;
            t.Hours = 6;
            //调用Get访问器
            Console.WriteLine("以小时为单位计算时间："+t.Hours);

            Console.WriteLine("=================静态构造函数================");


            Bus.Drive();
            Bus.Drive();


            Console.ReadKey();
        }
        //迭代器方法
        public static IEnumerable<int> Fibs()
        {
            int f1 = 1, f2 = 1;
            while (true)
            {
                yield return f1;
                yield return f2;
                f1 += f2;
                f2 += f1;
            }
        }
    }
}

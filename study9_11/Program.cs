using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================    try嵌套    =====================\n");
            try
            {
                Console.Write("输入第一层数据");
                int.Parse(Console.ReadLine());
                try
                {
                    Console.Write("输入第二层数据");
                    int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("第二层异常！！！");
                }
            }
            catch
            {
                Console.WriteLine("第一层异常！！！");
            }


            Console.WriteLine("\n\n\n===================    while循环  1~100的和   =====================\n");
            int count = 0, sum = 0;
            while (count < 100)
            {
                count++;
                sum += count;
            }
            Console.WriteLine("0~100的和为：{0}", sum);


            Console.WriteLine("\n\n\n===================    for循环  美股熔断   =====================\n");
            Console.WriteLine("我是巴菲特今年我91，我见证了美股1次熔断");
            Console.WriteLine("我是XXX，今年我21岁了，我见证了");
            for (int i = 2; i < 6; i++)
            {
                Console.WriteLine("美股第{0}次熔断", i);
            }
            Console.WriteLine("巴菲特：我还是太年轻了！");

            Console.WriteLine("\n\n\n===================    for循环  求奇数和偶数的和   =====================\n");
            int jsum = 0, osum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    osum += i;
                }
                else
                {
                    jsum += i;
                }
            }
            Console.WriteLine("0~100之间，奇数的和为：{0}，偶数的和为：{1}", jsum, osum);
            Console.WriteLine("\n\n\n===================    for循环嵌套   =====================\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("外循环\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t内循环");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n===================    九九乘法表   =====================\n");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n\n===================    goto 语法的使用   =====================\n");
            int num = 0, sum01 = 0;
            loop: //标记点可以在任何位置
            if (num < 100)
            {
                sum01 += num;
                num++;
                goto loop;
            }
            Console.WriteLine(sum01);

            string functiona = function();
            Console.WriteLine("function返回结果：{0}", functiona);
            function2();
            Console.WriteLine("function2");

            Console.ReadKey();
        }
        static string function()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 3) {
                        return "成功";
                    }
                }
            }
            return "失败";
        }
        static void function2()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 3)
                    {
                        return;
                    }
                }
            }
            return;
        }
    }
}

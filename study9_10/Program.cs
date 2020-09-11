using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  IF判断使用
            bool isYear = true;
            // 按下TAB键可以快速填充出IF语句
            if (isYear)
            {
                Console.WriteLine("瑞年");
            }
            //产生两个随机数范围是0~100的随机数a和b，比较两者大小，使得a大于b
            int a, b, c; // c为中间变量 发现a<b交换两者的值
            //产生随机数
            Random rNum = new Random();
            //设定产生随机数的范围
            a = rNum.Next(0, 100);
            b = rNum.Next(0, 100);
            if (a < b)
            {
                c = a;
                a = b;
                b = c;
            }
            Console.WriteLine("降序值:a:{0},b:{1}", a, b);
            #endregion

            Console.WriteLine("===========计算成绩等级=======================");
            #region 判断成绩等级
            try
            {
                Console.WriteLine("请输入您的考试成绩");
                int mark = Convert.ToInt32(Console.ReadLine());
                //考试评级等级
                string result;
                //判断考试成绩
                if (mark >= 90)
                {
                    result = "优秀";
                }
                else if (mark >= 80 && mark < 90)
                {
                    result = "良";
                }
                else if (mark >= 70 && mark < 80)
                {
                    result = "中";
                }
                else if (mark >= 60 && mark < 70)
                {
                    result = "及格";
                }
                else
                {
                    result = "不及格";
                }
                Console.WriteLine("您当前的考试成绩为：{0},考试等级为：{1}", mark, result);
            }
            catch
            {
                Console.WriteLine("输入内容有误");
            }
            #endregion 


            Console.WriteLine("===========计算分段函数=======================");
            #region 计算分段函数
            try
            {
                Console.WriteLine("请输入一个数值");
                int x = Convert.ToInt32(Console.ReadLine());
                //考试评级等级
                int y;
                //判断考试成绩
                if (x > 0)
                {
                    y = 1;
                }
                else if (x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = -1;
                }
                Console.WriteLine("当前输入的数值为：{0},计算结果为：{1}", x, y);
            }
            catch
            {
                Console.WriteLine("输入内容有误");
            }
            #endregion

            Console.WriteLine("===========使用IF嵌套判断闰年=======================");
            #region 使用IF嵌套判断闰年
            try
            {
                Console.WriteLine("请输入要判断的年份：");
                int years = Convert.ToInt32(Console.ReadLine());
                string msgs;
                if (years % 400 == 0)
                {
                    msgs = "是";
                }
                else
                {
                    if (years % 4 == 0 && years % 100 != 0)
                    {
                        msgs = "是";
                    }
                    else
                    {
                        msgs = "不是";
                    }
                }
                Console.WriteLine("当前输入的年份：{0} {1}闰年", years, msgs);
            }
            catch
            {
                Console.WriteLine("输入内容有误");
            }
            #endregion
            #region
            //使用时间日期函数来判断是否闰年
            if (DateTime.IsLeapYear(2004))
            {
                Console.WriteLine("是闰年");
            }
            else
            {
                Console.WriteLine("不是闰年 ");
            }

            int aa = 2004;
            if (aa % 400 == 0)
            {
                Console.WriteLine("闰年");
            }
            else if (aa % 4 == 0)
            {
                Console.WriteLine("闰年");
            }
            else if (aa % 100 == 0)
            {
                Console.WriteLine("闰年");
            }
            else
            {
                Console.WriteLine("不是闰年");
            }
            #endregion

            Console.WriteLine("===========使用switch判断成绩=======================");
            #region 使用switch判断成绩
            try
            {
                Console.WriteLine("请输入成绩等级：");
                String s = Console.ReadLine();
                switch (s)
                {
                    case "A":
                        Console.WriteLine(" 'A' 的成绩范围是90-100之间");
                        break;
                    case "B":
                        Console.WriteLine(" 'B' 的成绩范围是80-90之间");
                        break;
                    case "C":
                        Console.WriteLine(" 'C' 的成绩范围是70-80之间");
                        break;
                    case "D":
                        Console.WriteLine(" 'D' 的成绩范围是60-70之间");
                        break;
                    case "E":
                        Console.WriteLine(" 'F' 的成绩范围是60分以下");
                        break;
                    default:
                        Console.WriteLine("请输入正确的成绩等级");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("输入内容错误");
            }
            #endregion

            Console.WriteLine("===========使用while循环=======================");
            #region 使用while循环
            int i = 1, jsum = 0,osum =0,sum = 0;
            while (i <= 100) {
                if (i % 2 == 0)
                {
                    osum += i;
                }
                else {
                    jsum += i;
                }
                sum += i;
                i++;
            }
            Console.WriteLine("所有奇数的和：{0} ， 所有偶数的和为：{1}，所有数的和为：{2}",jsum,osum,sum);
            #endregion

            Console.WriteLine("===========使用do...while循环=======================");
            #region 使用do...while循环

            int o = 1, jsum1 = 0, osum1 = 0, sum1 = 0;
            do
            {
                sum1 += o;
                if (o % 2 == 0)
                {
                    osum1 += o;
                }
                else
                {
                    jsum1 += o;
                }
                o++;
            } while (o<=100);
            Console.WriteLine("所有奇数的和：{0} ， 所有偶数的和为：{1}，所有数的和为：{2}", jsum1, osum1, sum1);
            #endregion


            Console.WriteLine("===========求任意两个正整数的最大公约数与最小公倍数=======================");
            try
            {
                Console.WriteLine("请输入任意两个数：");
                int num001 = 1;
                int num01 = int.Parse(Console.ReadLine());
                int num02 = int.Parse(Console.ReadLine());
                while (num001>1) {
                    if (num01 % num001 == 0 && num02 % num001 == 0) { 
                    }
                    num01++;
                }
            } catch
            {
                Console.WriteLine("输入的数值不正确");
            }



            Console.ReadKey();
        }
    }
}

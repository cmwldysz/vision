using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组的生成和初始化
            Console.WriteLine("==================  for打印一维数组   ==================\n");
            //第一种方式
            int[] a1;
            a1 = new int[3];
            //第二种方式
            int[] a2 = new int[3];
            //第三种方式：初始化的时候赋值每一个数组
            string[] a3 = new string[3] { "1", "3", "5" };
            //第四种方式：简写忽略 newdouble[3]直接按给定的内容申请空间
            double[] a4 = { 1.1, 3.4, 6.5 };
            //第五种方式
            int[] a5 = new int[3];
            a5[0] = 1;
            a5[1] = 3;
            a5[2] = 5;

            int[] a6 = new int[30];
            a6[0] = 1;
            a6[1] = 1;
            Console.Write("{0}\t{1}\t", a6[0],a6[1]);
            for (int i = 2; i < 30; i++)
            {
                a6[i] = a6[i - 1] + a6[i - 2];
                Console.Write(a6[i] + "\t");
                if ((i+1)% 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            //使用一维数组，随机产生100个学生的成绩，计算学生的平均成绩，并统计高于平均分的成绩的学生人数
            Console.WriteLine("\n\n==================  打印学生成绩   ==================\n");
            int[] a7 = new int[100];
            int sum = 0,num =0;
            double avg;
            Random rNum = new Random();
            Console.WriteLine("所有学生成绩为：");
            for (int i = 0; i < 100; i++)
            {
                a7[i] = rNum.Next(0,101);
                sum += a7[i];
                Console.Write(a7[i] + "\t");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            avg = sum / 100.0;
            for (int i = 0; i < 100; i++)
            {
                if (a7[i] > avg) {
                    num++;
                }
            }
            Console.WriteLine("所有学生的总分为：{2}\t平均分为：{0}\t高于平均分的人数有：{1}位",avg,num,sum);


            Console.WriteLine("\n\n==================  foreach打印一维数组   ==================\n");
            foreach (var item in a7)
            {
                Console.Write(item+ "\t");
            }
            Console.WriteLine();

            Console.WriteLine("\n\n==================  for打印二维数组   ==================\n");
            //第一种方式：
            int[,] b = new int[4, 4];
            int[,] c = new int[4,4];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i,j] = i * 4 + j + 1;
                    Console.Write(b[i,j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n==================  二维数组打印上三角   ==================\n");

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n==================  二维数组打印下三角   ==================\n");

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(b[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n==================  转置矩阵   ==================\n");

            for (int i = 0; i < b.GetLength(0); i++)for (int j = 0; j < b.GetLength(1); j++)c[j, i] = b[i, j];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}

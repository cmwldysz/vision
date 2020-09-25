using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_24枚举与结构_字符串处理
{
    #region 枚举
    enum color { 
        Red, //关键值为0，关联值也是下标
        Green,
        Blue
    }
    #endregion
    #region 结构的嵌套
    struct Student {
        //嵌套结构（分数）
        public struct Grade {
            public string courseName;//课程名称
            public double courseGrade;//分数
            public Grade(string name, double grade) {
                courseName = name;
                courseGrade = grade;
            }
        }
        public string studentID, studentName;//学号，姓名
        public Grade[] grades;//分数（嵌套结构类型）
        public Student(string id, string name) {
            studentID = id;
            studentName = name;
            grades = new Grade[3];
        }
    }
    #endregion
    #region 结构:平面坐标
    public struct Point {
        public int x, y;
        public static int z = 1;//静态字段可以有变量初始化
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("==================结构===================");

            Point p1 = new Point();//调用默认的构造函数
            Console.WriteLine("平面坐标 1：x={0},y={1}", p1.x, p1.y);
            Point p2 = new Point(10, 10);//调用默认的构造函数
            Console.WriteLine("平面坐标 2：x={0},y={1}", p2.x, p2.y);
            Point p3;
            p3.x = 22;p3.y = 33;
            Console.WriteLine("平面坐标 3：x={0},y={1}", p3.x, p3.y);

            Console.WriteLine("==================结构的嵌套===================");
            Student s1 = new Student("2020092401","张三");
            s1.grades = new Student.Grade[] { new Student.Grade("语文",80), new Student.Grade("英语", 90) ,new Student.Grade("数学", 98) };
            Console.WriteLine("Student ID={0},StudentName={1}",s1.studentID,s1.studentName);
            //遍历显示成绩
            foreach (Student.Grade item in s1.grades)
            {
                Console.WriteLine("course={0},geade={1}",item.courseName,item.courseGrade);
            }
            Console.WriteLine("==================枚举===================");
            Console.WriteLine(color.Blue);
            Console.WriteLine((int)color.Blue);
            color B = color.Blue;
            switch (B)
            {
                case color.Red:
                    break;
                case color.Green:
                    break;
                case color.Blue:
                    break;
                default:
                    break;
            }
            color color1 = color.Blue;
            if (color1 == color.Red)
            {
                Console.WriteLine("color1 is Red");
            }
            else {
                Console.WriteLine("color1 is not Red");
            }
            color color2 = color.Blue;
            switch (color2)
            {
                case color.Red:
                    Console.WriteLine("color2 is Red");
                    break;
                case color.Green:
                    Console.WriteLine("color2 is Green");
                    break;
                case color.Blue:
                    Console.WriteLine("color2 is Blue");
                    break;
                default:
                    break;
            }
            Console.WriteLine("color.Green={0}", color.Green);
            Console.WriteLine("color.Green={0}", (int)color.Green);
            Console.WriteLine("==================字符串===================");
            string hello = "hello \nworld";
            string filePath = @"\\My Document\";
            string s = @"You say""goodbye""";
            Console.WriteLine(hello);
            Console.WriteLine(filePath);
            Console.WriteLine(s);

            int n = s.Length;//属性，获取字符串长度
            bool b = string.IsNullOrEmpty(s);//判断字符串是否为空或NULL
            bool c = string.IsNullOrWhiteSpace(s);//判断字段串是否为NULL或者空白字符串
            //截取字符串
            string ss1 = s.Substring(2, 5);//截取从索引I开始到N个字符串
            //大写转小写
            string ss2 = ss1.ToUpper();//转大写
            string sss = ss1.ToLower();//转小写
            //字符串去空白
            string a = s.Trim();//去空白 前后两边
            //s.TrimEnd(); s.TrimStart();//去前空格  去后空格

            //比较字符串
            bool b1 = string.Equals("abc", "ABC");//对比字符串是否有相同的
            bool b2 = "ABC".Equals("abc");//对比字符串
            int b3 = "ABC".CompareTo("abc");//结果为1

            //查找字符串
            int i1 = "ABcDAbEFD".IndexOf("Ab");
            int i2 = "ABcDAbEFD".IndexOf("B");
            int i3 = "ABcDAbEFD".IndexOf("B",   2,6);
            //插入字符串
            string u1 = s.Insert(1, "CFA");//在指定索引1的位置插入CFA
            string u2 = s.Remove(3);//删除索引3开始至末尾的字符
            string u3 = s.Replace(s, "A");//将字符串S替换成A

            //拆分字符串
            string words = "one.two!three.four:five six";
            char[] separators = new char[] { ' ',',','.',':','!'};
            string[] splits = words.Split(separators);//结果为：
            string Z = string.Join("|", splits);
            Console.WriteLine(Z);

            string T1 = "hello";string T2 = T1;
            T1 += "and goodbye";
            //T2[0] = 'A';
            Console.WriteLine(T2);

            StringBuilder sb0 = new StringBuilder("Hello World!");
            Console.WriteLine(sb0[1]);
            sb0[2] = 'U';
            #endregion


            Console.WriteLine("==================ArrayList基本操作===================");

            ArrayList al = new ArrayList();
            al.Add(1);al.Add(2);al.Add(3);
            al.Insert(1, "A");
            al.Remove(3);
            al.RemoveAt(2);
            for (int i = 0; i < al.Count; i++)
            {
                Console.Write("{0}\t", al[i]);
            }
            Console.WriteLine();
            foreach (var item in al)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
            al.Clear();
            Console.WriteLine(al.Capacity);//最大容量
            Console.WriteLine(al.Count);//实际容量
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                al.Add(i);
                Console.WriteLine(al.Capacity);//最大容量
                Console.WriteLine(al.Count);//实际容量
                Console.WriteLine("------------------ +i+ ------------------");
            }

            Console.WriteLine("==================装箱和拆箱===================");
            Object aa;
            int bb = 10;
            aa = bb;//装箱：值类型转换成引用类型
            int cc;
            cc = (int)aa;//拆箱：引用类型转换成值类型

            ArrayList list = new ArrayList();
            Stopwatch sw = new Stopwatch();//计时类
            sw.Start();
            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);
            }
            sw.Stop();//停止计时
            Console.WriteLine(sw.Elapsed);


            List<int> list1 = new List<int>();
            Stopwatch sw1 = new Stopwatch();//计时类
            sw1.Start();
            for (int i = 0; i < 10000; i++)
            {
                list1.Add(i);
            }
            sw1.Stop();//停止计时
            Console.WriteLine(sw1.Elapsed);

            Console.WriteLine("==================list使用===================");
            List<int> list2 = new List<int>();
            list2.Add(1); list2.Add(2); list2.Add(3);
            list2.Insert(1, 4);
            list2.Remove(3);
            list2.RemoveAt(2);
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write("{0}\t", list2[i]);
            }
            Console.WriteLine();
            foreach (var item in list2)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

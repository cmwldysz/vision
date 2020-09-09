using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"""";
            //1.起到连接的作用
            Console.WriteLine(str + "超人视觉" + str);
            //2.起到相加的作用
            int a = 1;
            int b = 2;
            Console.WriteLine("a+b={0}", a+b);
            //3.拓展知识
            string str1 = string.Format("a+b={0}", a + b);
            Console.WriteLine(str1);
            Console.WriteLine("====================");

            //课堂作业,练习登记显示个人信息，姓名、年龄、地址、联系方式显示出来
            string name = "姓名";
            string age = "女";
            int old = 20;
            string address = "地址";
            string tel = "18188883333";
            //占位符
            string userInfo1 = string.Format("用户信息1\n姓名：{0}\n性别：{1}\n年龄：{2}\n地址：{3}\n联系方式：{4}", name, age, old, address, tel);
            Console.WriteLine(userInfo1);
            Console.WriteLine("====================");
            //加号填充
            Console.WriteLine("用户信息2\n姓名："+name+"\n性别："+age+"\n年龄："+old+"\n地址："+address+"\n联系方式："+tel);
            Console.WriteLine("====================");

            int n1 = 10;
            int n2 = 20;
            //1.使用第三方变量
            int temp = n1; //将变量存储起来
            n1 = n2; // 对n1进行赋值
            n2 = temp; // 对n2赋值第三方变量
            Console.WriteLine("交换变量后的值：n1:{0},n2:{1}",n1,n2);

            Console.ReadLine();
        }
    }
}

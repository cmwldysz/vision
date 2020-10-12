using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study10_9委托
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void MyDel(int value);//声明委托
        private void button1_Click(object sender, EventArgs e)
        {
            void printLow(int value) {
                Console.WriteLine("{0}-Low Volue",value);
            }
            void PrintHight(int value){
                Console.WriteLine("{0}-Hight Value",value);
            }
            void PrintNumber(double value)
            {
                Console.WriteLine("{0}-Value", value);
            }
            //创建一个随机数
            Random rand = new Random();
            int randValue = rand.Next(99);
            //声明一个委托
            MyDel del;
            //使用委托
            del = randValue < 50 ? new MyDel(printLow) : new MyDel(PrintHight);
            //执行委托
            del(randValue);
            MyDel del2 = printLow;

        }
        //声明委托类型
        delegate void MyDel1(int x);
        //声明一个类
        class MyInstObj {
            public void MyM1(int x) {
                Console.WriteLine("实例方法：x="+x);
            }
            public static void OtherM2(int x)
            {
                Console.WriteLine("静态方法：x=" + x);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MyDel1 delVar, dVal;
            //实例化对象
            MyInstObj myInstObj = new MyInstObj();
            delVar = new MyDel1(myInstObj.MyM1);//实例方法
            dVal = new MyDel1(MyInstObj.OtherM2);//静态方法
            //创建委托引用并保存-第二种方法
            delVar = myInstObj.MyM1;//实例方法
            dVal = MyInstObj.OtherM2;//静态方法
            // 第二种方法是一种快捷方法，它仅仅由方法说明符组成。和方法一的代码是等价的。这种快捷语法能够工作是因为在方法名称和其相应的委托类型之间存在隐式转换
            //调用
            delVar(1);
            dVal(2);
        }
        #region
        delegate int algorithm(int a, int b);
        static int TEST(int a, int b, algorithm function) {
            //调用委托
            return function(a, b);
        }
        //加法
        static int addition(int a, int b)
        {
            return a + b;
        }
        //减法
        static int sub(int a, int b)
        {
            return a - b;
        }
        //乘法
        static int Multiplication(int a, int b)
        {
            return a * b;
        }
        //除法
        static int division(int a, int b)
        {
            return a / b;
        }
        #endregion
        private void button3_Click(object sender, EventArgs e)
        {
            int Number1 = 2;
            int Number2 = 3;
            //调用加法
            Console.WriteLine(Number1 + "+" + Number2 + "=" + TEST(Number1, Number2, addition));
            //调用减法
            Console.WriteLine(Number1 + "-" + Number2 + "=" + TEST(Number1, Number2, sub));
            //调用乘法
            Console.WriteLine(Number1 + "*" + Number2 + "=" + TEST(Number1, Number2, Multiplication));
            //调用除法
            Console.WriteLine(Number1 + "/" + Number2 + "=" + TEST(Number1, Number2, division));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyDel1 delA, delB;
            //实例化对象
            MyInstObj myInstObj = new MyInstObj();
            //创建委托引用 - 第二种方法
            delA = myInstObj.MyM1;
            delB = MyInstObj.OtherM2;
            MyDel1 delC = delA + delB;
            delC(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //实例化对象
            MyInstObj myInstObj = new MyInstObj();
            //创建委托并保存引用
            MyDel1 delA = myInstObj.MyM1;
            MyDel1 delB = MyInstObj.OtherM2;
            delA += MyInstObj.OtherM2;
            delA -= myInstObj.MyM1;//删除实例方法
            delA(1);

        }
        delegate int MyDel2();//声明有返回值得方法
        class MyClass {
            int IntValue = 5;
            public int Add2()
            {
                IntValue += 2;
                return IntValue;
            }
            public int Add3()
            {
                IntValue += 3;
                return IntValue;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            MyDel2 mDel = mc.Add2;//创建并初始化委托
            mDel += mc.Add3;//添加方法
            mDel += mc.Add2;//添加方法

            Console.WriteLine("Value:{0}",mDel());
        }
        delegate void MyDel3(ref int x);//声明有返回值得方法
        class MyClass2
        {
            public void Add2(ref int x)
            {
                x += 2;
            }
            public void Add3(ref int x)
            {
                x += 3;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MyClass2 mc = new MyClass2();
            MyDel3 mDel = mc.Add2;
            mDel += mc.Add3;
            mDel += mc.Add2;
            int x = 5;
            mDel(ref x);

            Console.WriteLine("Value:{0}", x);
        }
        delegate void Other(int intParame);
        delegate void SomeDel(int x,params int[] y);
        private void button8_Click(object sender, EventArgs e)
        {
            //省略了参数，没有使用
            Other del = delegate
            {
                Console.WriteLine("hello word!");
            };
            SomeDel mDel = delegate (int x, int[] y) {
                foreach (int item in y)
                {
                    Console.WriteLine(item);
                }
            };
            del(1);
            Console.WriteLine("===========================");
            mDel(1,2,3,4,5,6,7,8,9,9,0);
        }
        delegate int Other1(int intParame);
        private void button9_Click(object sender, EventArgs e)
        {
            //匿名方法
            Other1 del1 = delegate (int x){ return x + 1;};
            //Lambda表达式
            Other1 del2 = (int x) => { return x + 1; };
            Other1 del3 = (x) => {return x + 1; };
            Other1 del4 = x => { return x + 1; };
            Other1 del5 = x => x + 1;
        }
    }
}

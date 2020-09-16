using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace study9_16
{
    //类与对象
    class Counter {
        public int number;//实例字段
        public static int count;//静态字段
        public Counter() {
            count = count + 1;
            number = count;
        }
        public void ShowInStance() {
            //正确：实例方法中可以直接访问引用的实例字段
            Console.WriteLine("动态：boject:{0}",number);
            //正确：实例方法内可以直接访问静态字段
            Console.WriteLine("动态：count:{0}",count);
        }
        public static void ShowStatic() {
            //错误：静态的方法不能直接引用实例字段,如需引用需创建对象
            //Console.WriteLine("boject:{0}", number);
            //正确使用方法
            Counter c1 = new Counter();
            Console.WriteLine("静态：boject:{0}", c1.number);
            //正确：实例方法内可以直接访问静态字段
            Console.WriteLine("静态：count:{0}", count);
        }
    }
    //this关键字
    class ThisTest {
        public int i1 = 123;
        public string s1 = "abc";
        public ThisTest(int i1,string s1){
            this.i1 = i1;
            this.s1 = s1;
        }
        public ThisTest(int i2, string s1, int i3)
        {
            i1 = i2;
            this.s1 = s1;
        }
        public void printInfo()
        {
            int i1 = 456;
            string s1 = "def";
            Console.WriteLine(i1+ " "+s1); ;
            Console.WriteLine(this.i1+ " " +this.s1);
        }
    }
    //访问修饰符
    class Person1 {
        public const int PRETIREMENT_AGE = 65;//访问不受限
        public string name;//访问不受限
        internal string nickName; //当前程序内可以访问
        protected bool isMarrier;//在person类或派生类中可以访问
        private int age; // 只能在person类中访问
        string creditiCarNum;//使用默认访问修饰符：provate。只能在类中可以访问
        public void Speak()//访问不受限
        {
            Console.WriteLine("hi");
        }
        public void Mothod1() { 
            //对当前类的成员都可以访问
        }
    }
    //常量与字段
    class person {
        public const int RETIREMENT_AGE = 60;//声明了一个常量
        public const int RETIREMENT_AGE_DELAY = RETIREMENT_AGE + 60;
        string name;int age;//声明了两个变量
    }
    //只读字段
    class ReadOnlyField
    {
        public int x;
        public readonly int y = 2;//声明并初始化只读字段
        public readonly int z;//声明只读变量
        public ReadOnlyField() {
            z = 3;//初始化只读字段
        }
        public ReadOnlyField(int p1,int p2,int p3){
            this.x = p1;
            this.y = p2;
            this.z = p3;
        }
    }
    //方法 、通过表达式声明方法
    class SimpleMath {
        public int x,y,sum,xpingfang,ypingfang;
        public void add() {
            sum = this.x + this.y;
        }
        public void square()
        {
            xpingfang = this.x * this.x;
            ypingfang = this.y * this.y;
        }
        public void show() {
            Console.WriteLine("当x={0}\ty={1}时：", this.x, this.y);
            Console.WriteLine("x+y={0}", sum);
            Console.WriteLine("x的平方为：{0}，y的平方为：{1}", xpingfang,ypingfang);
        }
        public SimpleMath(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public SimpleMath(){}
        public int addTwoNumber(int x,int y) {
            return x + y;
        }
        public int squareNum(int x) {
            return x * x;
        }
        public static void display(int x) {
            Console.WriteLine("结果为：{0}",x);
        }
        public int addTwoNumber1(int x, int y)=>x + y;
        public int squareNum1(int x)=> x * x;
        public static void display1(int x)=>Console.WriteLine("结果为：{0}", x);
    }
    //参数
    class Test
    {
        public static void Swap(int x = 7, int y = 8)
        {
            Console.WriteLine("[swap] Before x={0},y={1}", x, y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("[swap] After x={0},y={1}", x, y);
        }
        public static void Swap1(ref int x, ref int y)
        {
            Console.WriteLine("ref[swap] Before x={0},y={1}", x, y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("ref[swap] After x={0},y={1}", x, y);
        }
        public static bool MyTryParse(string str, out int Number)
        {
            bool result;
            try
            {
                Number = Convert.ToInt32(str);
                result = true;
            }
            catch (Exception)
            {
                Number = 0;
                result = false;
            }
            return result;
        }
        public static void F(int a=1,params int[] args)
        {
            Console.Write("数组包含了{0}个元素", args.Length);
            foreach (int item in args) Console.Write("{0}\t", item);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region

            Console.WriteLine("=============类与对象===================");
            Counter c1 = new Counter();//创建对象
            c1.ShowInStance(); //正确：对象调用方法
            //c1.ShowStatic();//错误：不能用对象调用静态方法
            Console.WriteLine("object:{0}", c1.number); //正确：用对象引用实例字段
            //Console.WriteLine("object:{0}", Counter.number); //错误：不能用类名引用实例字段
            //Console.WriteLine("count:{0}", c1.count);//错误：不能用对象引用静态字段
            Console.WriteLine("count:{0}", Counter.count);//正确：类名引用静态字段
            Counter.ShowStatic();//正确：静态方法只能通过类名调用
            Counter.ShowStatic();//正确：静态方法只能通过类名调用
            Counter.ShowStatic();//正确：静态方法只能通过类名调用
            Counter.ShowStatic();//正确：静态方法只能通过类名调用
            Counter.ShowStatic();//正确：静态方法只能通过类名调用

            Console.WriteLine("=============this关键字===================");
            ThisTest tt1 = new ThisTest(1234, "使用this");
            tt1.printInfo();
            ThisTest tt2 = new ThisTest(123, "不使用this",123);
            tt2.printInfo();


            Console.WriteLine("=============访问修饰符===================");
            //对程序的类中的方法，对象person成员的访问权限如下
            //public和internal成员都可以访问；projectted和private成员不可访问
            Console.WriteLine("=============常量与字段===================");
            //调用显示常量
            Console.WriteLine("AGE={0}，AGE_DELAY={1}",person.RETIREMENT_AGE,person.RETIREMENT_AGE_DELAY);

            Console.WriteLine("=============只读字段===================");

            ReadOnlyField p1 = new ReadOnlyField();//无参
            p1.x = 1;//正确
            //p1.z = 33;//错误：编译错误对只读字段赋值
            Console.WriteLine("p1:x={0},y={1},z={2}",p1.x,p1.y,p1.z);
            ReadOnlyField p2 = new ReadOnlyField(11,22,33);//无参
            Console.WriteLine("p2:x={0},y={1},z={2}", p2.x, p2.y, p2.z);
           
            Console.WriteLine("============方法===================");
            //方法的声明和调用：定义一个简单地SimpleMath类，实现整数相加、整数的平方、显示运算的结果的方法
            SimpleMath sm = new SimpleMath(3,4);
            sm.add();
            sm.square();
            sm.show();

            int result;SimpleMath obj = new SimpleMath();
            result = obj.addTwoNumber(1, 2);
            SimpleMath.display(result);
            SimpleMath.display(obj.squareNum(result));
            Console.WriteLine("============通过表达式声明方法===================");
            int result1; SimpleMath obj1 = new SimpleMath();
            result1 = obj1.addTwoNumber(1, 2);
            SimpleMath.display(result1);
            SimpleMath.display1(obj1.squareNum(result1));
            Console.WriteLine("============ref 参数===================");
            int x = 1, y = 2;
            Console.WriteLine(" Before x={0},y={1}", x, y);
            Test.Swap(x, y);
            Console.WriteLine(" After x={0},y={1}", x, y);
            Console.WriteLine(" Before 不带参数");
            Test.Swap();
            Console.WriteLine(" After 不带参数");
            Console.WriteLine("ref Before x={0},y={1}", x, y);
            Test.Swap1(ref x, ref y);
            Console.WriteLine("ref After x={0},y={1}\n\n", x, y);
            Console.WriteLine("============ out 参数===================");
            string s = "123abc";
            int n;
            if (int.TryParse(s, out n))
            {
                Console.WriteLine(n);
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine(n);
                Console.WriteLine("不能转换成整数");
            }
            if (Test.MyTryParse(s, out n))
            {
                Console.WriteLine(n);
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine(n);
                Console.WriteLine("不能转换成整数");
            }
            #endregion

            Console.WriteLine("============ params 参数===================");

            int[] arr = { 1, 2, 3 };
            Test.F(7,arr);
            Test.F(10, 20, 30, 40);
            Test.F();
            Console.ReadKey();
        }
    }
}

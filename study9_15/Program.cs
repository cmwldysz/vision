using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__15
{
    class Program
    {
        class MyHelloWord {
            //静态的方法，无需实例化。在编译时已经分配了空间，可直接调用
            public static void SayHello() {
                Console.WriteLine("Hello Word!");
            }
            //非静态的方法，需要将类实例化形成对象，然后调用。new对象时才会生成空间，无需实例化，结束之后可以释放内存
            public void CSayHello() {
                Console.WriteLine("你好!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("==============     1.静态和非静态方法    ================");
            MyHelloWord.SayHello();
            MyHelloWord myHelloWord = new MyHelloWord();
            myHelloWord.CSayHello();
            //释放对象的内存空间
            myHelloWord = null;
            Console.WriteLine("==============    2. 默认构造函数    ================");
            Person person1 = new Person();
            person1.Pring();
            Console.WriteLine("=================");
            Person person2 = new Person("教练",29);
            person2.Pring();

            Console.WriteLine("==============     3.访问修饰符    ================");
            Bird bird = new Bird();
            Dog dog = new Dog();

            bird.SayHello();//引用internal成员
            dog.SayHello();//引用Public成员

            Console.WriteLine("==============     4.类的创建和使用    ================");
            //方式一：声明Person类型的变量，在赋值
            Person personA;
            personA = new Person("张三", 25);
            personA.Pring();
            //方式二：通过构造函数传递值
            Person personB  = new Person("李四", 18);
            personB.Pring();
            //方式三：对字段直接赋值
            Person personC = new Person();
            personC.name = "王五";
            personC.Pring();
            //方式四：对属性直接进行赋值
            Person personD = new Person() { Name = "王五",Age = 13};
            personD.Pring();
            Console.WriteLine("==============     5.分布类    ================");



            Console.WriteLine("==============    6. Object基类    ================");

            int[] a = new int[3];
            object[] objs = new object[3];
            objs[0] = 123;
            objs[1] = "abc";
            objs[2] = new DateTime(2020,9,15);
            foreach (var item in objs)
            {
                Console.WriteLine("object[{0},{1},{2},{3}]",item,item.GetType(),item.ToString(),item.GetHashCode());
            }
            Console.WriteLine("==============    7. 两个对象进行对比    ================");

            Person pr = new Person();
            Person pr2 = new Person("张三",26);
            Person pr3 = new Person { Name = "李四",age = 16};
            //进行比较
            if (pr2 == pr3) {
                Console.WriteLine("pr2与pr3相同。");
            } else {
                Console.WriteLine("pr2与pr3不相同。");
            }
            Person pr4 = pr3;
            if (pr4 == pr3)
            {
                Console.WriteLine("pr4与pr3相同。");
            }
            else
            {
                Console.WriteLine("pr4与pr3不相同。");
            }



            Console.ReadKey();
        }
    }
    //分布类
    public partial class PartialTest
    {
        protected string age;//类中的字段
        public void F2() //类中的方法
        {
        }
    }
    public class Test //等同于PartialTest类
    {
        protected string name;//类中的字段
        protected string age;//类中的字段
        public void F1() //类中的方法
        {
        }
        public void F2() //类中的方法
        {
        }
    }
    //
    class Bird //默认的访问修饰符是internal (本程序集可以访问)
    {
        public void SayHello()
        {
            Console.WriteLine("吱吱");
        }
    }
    public class Dog//访问修饰符是public(任意可以访问)
    {
        public void SayHello()
        {
            Console.WriteLine("旺旺");
        }
    }
    //类
    public class Person {
        //字段
        public string name;
        public int age;
        //属性   快捷键ctrl+r+e
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //默认的构造函数
        public Person()//不带参数的构造函数
        {
            this.name = "未知";
            this.age = 0;
        }
        //方法重载：构造函数
        public Person(string name,int age) {
            this.name = name;
            this.age = age;
        }
        public void Pring() {
            Console.WriteLine("name={0},age={1}", this.Name, this.Age);
        }
    }
}

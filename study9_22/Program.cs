using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_22
{
    #region 接口
    public interface IBankAccount //银行账号
    {
        void PayIn(decimal amount);//存款
        bool Writhdraw(decimal amount);//取款 并返回是否成功
        decimal Balance { get; }//余额
    }
    //转账银行账户
    public interface ITransferBankAccount : IBankAccount
    {
        bool TransferTo(IBankAccount destiation, decimal amount);//转账银行账号
    }
    //当前账户
    public class CurrenAccount : ITransferBankAccount
    {
        private decimal balance;//余额
        public void PayIn(decimal amount) { balance += amount; }//存款
        public bool Writhdraw(decimal amount)//取款
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("余额不足，取款失败！");
                return false;
            }
        }
        public decimal Balance { get { return balance; } }//返回余额
        //银行转账
        public bool TransferTo(IBankAccount destiation, decimal amount)
        {
            if (Writhdraw(amount) == true)
            {
                destiation.PayIn(amount);
                return true;
            }
            else {
                return false;
            }
        }
        public override string ToString()
        {
            return string .Format("Current Bank Account :Balance = {0:00}", this.Balance);
        }
    }
    #endregion
    #region  密封类
    class Parent
    {
        public virtual void MethodF()
        {
            Console.WriteLine("调用Parent的MethodF()");
        }
        public virtual void MethodG()
        {
            Console.WriteLine("调用Parent的MethodG()");
        }
    }
    class Child : Parent
    {
        public sealed override void MethodF()//密封方法
        {
            Console.WriteLine("调用Child的MethodF()");
        }
        public override void MethodG()  //重写基类继承的方法
        {
            Console.WriteLine("调用Child的MethodG()");
        }
    }
    //密封类
    sealed class Final : Child
    {
        // 密封方法不可以重写
        //public override void MethodF() { }
        //重写基类继承的方法
        public override void MethodG()
        {
            Console.WriteLine("调用Final的MethodG()");
        }
    }
    //密封类不可以派生
    //sealed class Final : Child { }

    #endregion
    #region  抽象类
    abstract class Animal
    {
        public string name;
        public abstract void SayHi();
        public Animal(string name)
        {
            this.name = name;
        }
    }
    class Dog : Animal
    {
        //重写SayHi
        public override void SayHi()
        {
            Console.WriteLine(this.name + "wow wow!!");
        }
        //构造函数
        public Dog(string name) : base(name) { }
    }
    class Cat : Animal
    {
        //重写SayHi
        public override void SayHi()
        {
            Console.WriteLine(this.name + "喵喵喵!!!");
        }
        //构造函数
        public Cat(string name) : base(name) { }
    }
    //class Horse : Animal{ } //编译错误 非抽象Horse继承了抽象类Animal但是，并未实现抽象方法

    abstract class Fish : Animal //编辑OK ，抽象类Fish继承了抽象类Animal但是并未实现抽象方法
    {
        public Fish(string name) : base(name) { } //构造函数
    }

    #endregion
    #region 虚方法和方法重写
    class Dimension//基类
    {
        protected double x, y;
        public Dimension() { }//默认构造函数
        public Dimension(double x, double y)
        {
            this.x = x; this.y = y;
        }//有参构造函数
        public virtual double Area()
        {
            return this.x * this.y;
        }
    }
    //派生类  圆
    class Circle : Dimension
    {
        public Circle(double r) : base(r, 0) { }
        public override double Area()//圆的面积
        {
            return Math.PI * x * x;
        }
    }
    //派生类  球体
    class Shere : Dimension
    {
        public Shere(double r) : base(r, 0) { }
        public override double Area()
        {
            return 4 * Math.PI * x * x;
        }
    }
    //派生类  圆柱体表面积
    class Cylinder : Dimension
    {
        public Cylinder(double r, double h) : base(r, h) { }
        public override double Area()
        {
            return 2 * Math.PI * x * x + 2 * Math.PI * x * y;
        }
    }
    #endregion
    #region 访问修饰符
    public class ClassA
    {
        protected double x_protected;//受保护的字段
        private double y_private;//私有字段

        public void setY(double y)//公共方法
        {
            this.y_private = y;
        }

        public double getY()//公共方法
        {
            return this.y_private;
        }

        public ClassA(double x, double y)
        {
            this.y_private = y;
        }

    }

    public class ClassB : ClassA
    {
        public double z_public;//公共实例字段

        public void print()    //公共实例方法
        {
            //OK，可访问基类的Protected成员
            Console.WriteLine(this.x_protected);
            //NO  不可访问私有字段
            //Console.WriteLine(this.y_private);
            //OK 可以访问公有方法(公有方法当中访问私有字段)
            Console.WriteLine(this.getY());
            //OK 可以访问公有的字段
            Console.WriteLine(this.z_public);
        }

        public ClassB(double x, double y, double z) : base(x, y)//调用带3个参数的构造函数,调基类
        {
            this.z_public = z;
        }

    }
    #endregion
    #region   继承
    class SuperClass1   //基类1 默认 继承object
    {
        public string name, sex;
    }

    class SuperClass11 : SuperClass1 //继承
    {
        public int age;
    } //派生类 继承与SuperClass1

    class SubClass12 : SuperClass1 //派生类 继承与SuperClass1
    {
        public int age;
        public SubClass12()//默认构造函数
        {
            Console.WriteLine("调用构造函数SubClass12()...");
        }
    } //派生类 继承与SuperClass1

    class SubClass13 : SuperClass1 //派生类
    {
        public int age;
        public SubClass13(int age)//默认构造函数
        {
            Console.WriteLine("调用构造函数SubClass13()...");
        }
    } //派生类 继承与SuperClass1

    //===============================================

    class SuperClass2//基类有参构造函数
    {
        public string name; public string sex;
        public SuperClass2(string name, string sex)
        {
            this.name = name; this.sex = sex;
            Console.WriteLine("调用构造函数SuperClass2(string name, string sex)...");
        }
    }

    //派生类SubClass21 编译错误，没有满足基类构造函数
    //class SubClass21 : SuperClass2
    //{

    //}
    //class SubClass22 : SuperClass2
    //{
    //    public int age;
    //    //public SubClass22()//编译错误
    //    //{
    //    //    //默认构造函数，自动调用基类，但是无法满足基类的要求(两个输入参数)
    //    //}
    //}

    class SubClass23 : SuperClass2//派生类
    {
        public int age;
        public SubClass23(string name, string sex, int age) : base(name, sex)
        {
            this.age = age;
            Console.WriteLine("调用SubClass23的构造函数 SubClass23(string name,string sex,int age) : base(name,sex)");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============继承=============");
            //调用默认的构造函数
            SubClass12 obj12 = new SubClass12();
            //调用有参的购置函数
            SubClass23 objsubClass = new SubClass23("教练", "男", 18);

            Console.WriteLine("=============访问修饰符=============");

            //派生类
            ClassB objclassb = new ClassB(1.0, 2.0, 3.0);

            //设置->访问修饰值
            objclassb.setY(2.2);
            objclassb.z_public = 3.3;
            //访问方法
            objclassb.print();//访问类的成员Print()

            Console.WriteLine("=============虚方法和方法重写=============");

            double r = 3.0, h = 5.0;
            Dimension[] dimension = { new Circle(r), new Shere(r), new Cylinder(r, h) };
            foreach (Dimension item in dimension)
            {
                //显示不同类型状态的表面积
                Console.WriteLine("Area of {0} = {1:0.00}", item.GetType(), item.Area());
            }

            Console.WriteLine("=============抽象类=============");
            //抽象类不能实例化
            //Animal an = new Animal();
            Animal[] animals = { new Dog("小白"), new Cat("小花") };
            foreach (Animal item in animals) item.SayHi();

            Console.WriteLine("=============密封类=============");

            Final obj = new Final();
            obj.MethodF();
            obj.MethodG();
            Console.WriteLine("=============接口=============");
            IBankAccount account1 = new CurrenAccount();//账户1
            ITransferBankAccount account2 = new CurrenAccount();//账户2
            account1.PayIn(200);//账户1存款200
            account2.PayIn(500);//账户2存款500
            account2.TransferTo(account1, 100);//账户2转账100元到账户1
            //显示余额
            Console.WriteLine("account1`s " + account1.ToString());
            Console.WriteLine("account2`s " + account2.ToString());




            Console.ReadKey();
        }
    }
}

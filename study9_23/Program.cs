using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study9_23
{
    #region 里氏转换
    class Friut { 
    
    }
    class Apple : Friut {
        public void EatA() {
            Console.WriteLine("我是苹果的吃法");
        }
    }
    class Banana : Friut {
        public void EatB()
        {
            Console.WriteLine("我是香蕉的吃法");
        }
    }
    #endregion
    #region 方法的重载
    class P0 {
        public void MethodA() {
            Console.WriteLine("调用P0的方法MethodA()");
        }
    }
    class C0 : P0
    {
        public void MethodA(string str)
        {
            Console.WriteLine("调用C0的方法MethodA(string str):" + str);
        }
        public void MethodB(string str1)
        {
            Console.WriteLine("调用C0的方法MethodB(string str1):" + str1);
        }
        public void MethodB(int str1)
        {
            Console.WriteLine("调用C0的方法MethodB(int str1):" + str1);
        }
    }
    #endregion
    #region 继承实现多态2
    interface ICommon { void f(); }//声明接口，定义无返回值函数
    abstract class Base { public abstract void g(); }//抽象类
    class Derived1 : Base, ICommon
    {
        //实现从接口继承的方法
        public void f() { Console.WriteLine("Derived1.f()"); }
        //重写从基类继承的方法
        public override void g()
        {
            Console.WriteLine("Derived1.g()");
        }
        //重新定义新方法h
        public void h()
        {
            Console.WriteLine("Derived1.h()");
        }
    }
    class Derived2 : ICommon {
        //实现从接口继承的方法
        public void f() { Console.WriteLine("Derived2.f()"); }
        //重新定义新方法h
        public void h()
        {
            Console.WriteLine("Derived2.h()");
        }
    }

    #endregion
    #region 继承实现多态1
    class Parent {
        public void MethodA() {
            Console.WriteLine("调用MethodA()");
        }
    }
    class Child : Parent {
        public void MethodB()
        {
            Console.WriteLine("调用MethodB()");
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============继承实现多态1===================");
            Parent oparent = new Parent();
            oparent.MethodA();

            Child ochild = new Child();
            ochild.MethodB();

            oparent = (Parent)ochild;//子类可以转父类，父类不可以转子类 
            oparent.MethodA();
            Console.WriteLine("=============继承实现多态2===================");
            Derived1 d1 = new Derived1();
            d1.f();
            d1.g();
            d1.h();
            Console.WriteLine();
            ICommon c1 = new Derived1();
            c1.f();
            Base b1 = new Derived1();
            b1.g();
            Console.WriteLine();
            object o1 = new Derived1();
            Console.WriteLine(o1.GetType());
            //o1.f();

            Console.WriteLine("=============方法的重载===================");
            C0 obj0 = new C0();
            obj0.MethodA("abc");
            obj0.MethodB("XYZ");
            obj0.MethodB(123);
            Console.WriteLine("=============里氏转换===================");
            //1、子类可以赋值给父类
            Friut fr = new Apple();

            //2、如果父类中装的是子类的对象，那么可以将这个父类转换为子类的对象
            Apple ap = (Apple)fr;
            ap.EatA();
            Console.WriteLine("---------------------------------");
            //3.IS用法
            Friut fr2 = new Banana();
            if (fr2 is Apple)
            {
                ap = (Apple)fr;
                ap.EatA();
                Console.WriteLine("转换成功！");
            }
            else
            {
                Console.WriteLine("转换失败！");
            }
            Console.WriteLine("---------------------------------");
            //4.AS用法
            Friut fr3 = new Banana();
            Banana ba = fr3 as Banana;
            if (ba != null)
            {
                ba.EatB();
                Console.WriteLine("转换成功！");
            }
            else
            {
                Console.WriteLine("转换失败！");
            }


            Console.ReadKey();

        }
    }
}

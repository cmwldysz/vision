using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10_12事件1
{
    //逆变与协变
    class Mammal { }
    class Dog : Mammal { }
    class Class2
    {
        public delegate Mammal HandlerMethod();//定义委托
        public delegate void HandlerMethod1(Mammal m);
        public delegate void HandlerMethod2(Dog m);
        public static Mammal FirstHandler() {
            Console.WriteLine("first handler");
            return null;
        }
        public static Dog SecondHandler()
        {
            Console.WriteLine("second handler");
            return null;
        }
        public static void ThirdHandler(Mammal m)
        {
            Console.WriteLine("third handler");
        }
        static void pMain() {
            //正常匹配：委托和方法一致
            HandlerMethod handler1 = FirstHandler;
            handler1();
            //协变：返回Dog值默认可以转换成Memmal
            HandlerMethod handler2 = SecondHandler;
            handler2();
            //正常匹配
            HandlerMethod1 handler3 = ThirdHandler;
            handler3(new Mammal());
            //逆变：参数Dog默认可以转换成Mammal（父类）
            HandlerMethod2 handler4 = ThirdHandler;
            handler4(new Dog());
            Console.ReadKey();
        }
    }
}

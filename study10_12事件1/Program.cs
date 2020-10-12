using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10_12事件1
{
    class Mom {
        public delegate void EatHandler();//创建一个委托
        public event EatHandler EatEvent;//创建一个事件
        //吃
        private void OnEat() {
            if (EatEvent!=null)
            {
                EatEvent();//吃饭的事件
            }
        }
        public void Cook()
        {
            Console.WriteLine("妈妈开始煮饭");
            Console.WriteLine("妈妈开始炒菜");
            OnEat();//发布消息，通知吃饭
        }
    }
    class Dad {
        public void Eat() {
            Console.WriteLine("爸爸：好的我这就来了");
        }
    }
    class Son {
        public void Eat() {
            Console.WriteLine("儿子：妈妈，我在玩一会，马上就过来");
        }
    }
    class Program
    {
        static void pmain(string[] args)
        {
            //实例化对象
            Mom objMom = new Mom();
            Dad objDad = new Dad();
            Son objSon = new Son();
            //事件的绑定
            //objMom.EatEvent += new Mom.EatHandler(objSon.Eat);
            objMom.EatEvent += objSon.Eat;
            objMom.EatEvent += objDad.Eat;
            objMom.Cook();
            Console.ReadKey();
        }
    }
}

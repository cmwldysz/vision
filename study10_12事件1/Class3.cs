using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10_12事件1
{
    class Class3
    {
        //泛型委托
        public delegate void del<T>(T item);//泛型
        public static void Notify(int i) {
            Console.WriteLine("Notify:{0}",i);
        }
        public static void DoubleNotify(double j) {
            Console.WriteLine("DoubleNotify:{0}",j);
        }
        static void Main()
        {
            del<int> m1 = new del<int>(Notify);
            del<double> m2 = new del<double>(DoubleNotify);
            m1(3);
            m2(4);
            Console.ReadKey();
        }
    }
}

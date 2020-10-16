using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10_15线程Mutex同步
{
    class task返回值
    {
        static void Main() {
            var t = Task<double>.Factory.StartNew(()=> {
                return Convert.ToInt32(Math.Pow(2,4));
            });
            Console.WriteLine("2的4次方为{0}",t.Result);
            Console.ReadKey();
        }
    }
}

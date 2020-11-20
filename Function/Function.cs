using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interface_Fuction;

namespace Function
{
    public class Function:IFunction
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Division(int a, int b)
        {
            return a / (double)b;
        }
    }
}

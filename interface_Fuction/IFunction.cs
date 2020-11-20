using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Fuction
{
    public interface IFunction
    {
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Add(int a, int b);
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Sub(int a, int b);
        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Multiply(int a, int b);
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double  Division(int a, int b);
    }
}

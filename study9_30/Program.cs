using stydy9_30;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study9_30
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ////1.加载窗体，加载完毕
            //if (DialogResult.OK == new Form1().ShowDialog())
            //{

            //    //2.登录窗体，登录成功
            //    if (DialogResult.OK == new Form4().ShowDialog())
            //    {
            //        //3.主窗体显示
            //        Application.Run(new Form7());
            //    }
            //}
            Application.Run(new FMain());
        }
    }
}

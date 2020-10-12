using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study10_10委托
{
    //声明委托
    delegate int MyDelegate(int op1, int op2, out int result);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Add(int op1, int op2, out int result) {
            Thread.Sleep(5000);//睡眠5秒，模拟实际耗时操作
            return (result = op1+op2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            MyDelegate d = Add;
            textBox1.AppendText("委托异步调用方法开始：\n");
            IAsyncResult iar = d.BeginInvoke(123,456,out result,null, null);
            textBox1.AppendText("执行其他操作");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                textBox1.AppendText(".");
            }
            textBox1.AppendText("等待...");
            //使用IAsyncResult.AsyncWaltHandle获取WaltHandle，使用WaitOne方法执行
            //阻塞等待，异步完成之时会发出WaltHandle信号，可通过WaitOne等待
            iar.AsyncWaitHandle.WaitOne();
            textBox1.AppendText("异步调用AsyncDelegate.Add()方法结束\n");
            //EndInvoke方法：若异步调用未完成，EndInvoke将一直阻塞到异步调用完成
            d.EndInvoke(out result,iar);

            textBox1.AppendText("异步委托结束："+result);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

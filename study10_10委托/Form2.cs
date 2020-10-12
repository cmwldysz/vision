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
    // 定义委托
    public delegate string TestMethod();
    public delegate void AllForm(string text);

    public partial class Form2 : Form
    {
        //AutoResetEvent testEvent = new AutoResetEvent(false);
        AllForm _allForm = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestMethod method = new TestMethod(Method1);
            string str = method();
            richTextBox1.AppendText(" 同步操作执行完成： " + str + " \r\n ");

            method = new TestMethod(Method2);
            IAsyncResult result = method.BeginInvoke(new AsyncCallback(Method2CallBack), method);

            // 阻止当前线程方法之一
            //testEvent.WaitOne();

            richTextBox1.AppendText(" this is button1_Click \r\n ");
        }

        public string Method1()
        {
            return " Method1 ";
        }

        public string Method2()
        {
            int k = 10;
            int count = 0;
            for (; k < 100; k++)
            {
                count += k;
                Thread.Sleep(1);
            }
            //Thread.Sleep(1000);
            return " Method2  " + count;
        }

        public void Method2CallBack(IAsyncResult iar)
        {
            TestMethod test = iar.AsyncState as TestMethod;
            string str = test.EndInvoke(iar);
            if (null != _allForm)
                richTextBox1.Invoke(_allForm, string.Format(" 异步执行完成调用回调方法 {0}\r\n ", str));
            //testEvent.Set();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _allForm = new AllForm(delegate (string text)
            {
                richTextBox1.AppendText(text);
            });
        }
    }
}

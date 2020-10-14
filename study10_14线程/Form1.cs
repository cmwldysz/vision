using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace study10_14线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //关闭跨线程访问限制
            //CheckForIllegalCrossThreadCalls = false;
        }

        Thread[] threads = new Thread[5];
        private void button1_Click(object sender, EventArgs e)
        {
            //Thread t = new Thread(() =>
            //{
            //    Method(this.progressBar1, Therad_lable_1);
            //    Method(this.progressBar2, Therad_lable_2);
            //    Method(this.progressBar3, Therad_lable_3);
            //    Method(this.progressBar4, Therad_lable_4);
            //    Method(this.progressBar5, Therad_lable_5);
            //});
            //t.Start();

            //Thread t1 = new Thread(() => Method(this.progressBar1, Therad_lable_1));
            //t1.Start();
            //Thread t2 = new Thread(() => Method(this.progressBar2, Therad_lable_2));
            //t2.Start();
            //Thread t3 = new Thread(() => Method(this.progressBar3, Therad_lable_3));
            //t3.Start();
            //Thread t4 = new Thread(() => Method(this.progressBar4, Therad_lable_4));
            //t4.Start();
            //Thread t5 = new Thread(() => Method(this.progressBar5, Therad_lable_5));
            //t5.Start();


            for (int i = 1; i < 6; i++)
            {
                ProgressBar progressBar = (ProgressBar)this.Controls.Find("ProgressBar" + i, false).FirstOrDefault();
                Label label = (Label)this.Controls.Find("Therad_lable_" + i, false).FirstOrDefault();
                threads[i - 1] = new Thread(() => Method(progressBar, label));
                //threads[i - 1].IsBackground = true;
                threads[i - 1].Start();
            }
        }
        void Method(ProgressBar progressBar,Label label) {
            //while (progressBar.Value<100)
            //{
            //    this.Invoke(new MethodInvoker(delegate () {
            //        progressBar.Value += 1;
            //        label.Text = progressBar.Value + "%";
            //    }));
            //    Thread.Sleep(50);
            //}
            for (int i = 0; i <= 100; i++)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    progressBar.Value = i;
                    label.Text = i.ToString() + "%";
                }));
                Thread.Sleep(50);
            }
        }
        //清空进度条
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                ProgressBar progressBar = (ProgressBar)this.Controls.Find("ProgressBar" + i, false).FirstOrDefault();
                Label label = (Label)this.Controls.Find("Therad_lable_" + i, false).FirstOrDefault();
                progressBar.Value = 0;
                label.Text = "0 %";
            }
        }
        void ClserBar() {
            for (int i = 1; i < 6; i++)
            {
                ProgressBar progressBar = (ProgressBar)this.Controls.Find("ProgressBar" + i, false).FirstOrDefault();
                Label label = (Label)this.Controls.Find("Therad_lable_" + i, false).FirstOrDefault();
                progressBar.Value = 0;
                label.Text = "0 %";
            }
        }
        //线程终止
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (threads[i] != null)
                {
                    threads[i].Abort();
                }
            }
        }
        //线程挂起
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "线程挂起")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (threads[i] != null)
                    {
                        threads[i].Suspend();
                    }
                }
                this.button2.Text = "线程唤醒";
            }
            else {
                for (int i = 0; i < 5; i++)
                {
                    if (threads[i] != null)
                    {
                        threads[i].Resume();
                    }
                }
                this.button2.Text = "线程挂起";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stydy9_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //叠加次数
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //令每一次进度条增加5
            this.panel2.Width += 5;
            //判断是否到达了北京panel的宽度
            if (this.panel2.Width >= this.panel1.Width)
            {
                this.timer1.Stop();
            }
            //==========================================
            this.label3.Text += ".";
            count++;
            if (count == 4)
            {
                this.label3.Text = "加载系统组件";
                count = 0;
            }
        }
    }
}

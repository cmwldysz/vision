using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study9_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string infomation = "";
            //获取textbox
            infomation += this.textBox1.Text + "\n";
            if (this.radioButton1.Checked == true)
            {
                infomation += this.radioButton1.Text + "\n";
            }
            else {
                infomation += this.radioButton2.Text + "\n";
            }
            //爱好
            //if (this.checkBox1.Checked == true)
            //{
            //    infomation += this.checkBox1.Text + "\n";
            //}
            for (int i =5; i < 9; i++)
            {
                //查找获取控件
                CheckBox check = (CheckBox)this.Controls.Find("checkBox" + i.ToString(), false).FirstOrDefault();
                //判断当前控件是否选中
                if (check.Checked == true) {
                    infomation += check.Text + "\n";
                }
            }
            this.label5.Text = infomation;
        }
    }
}

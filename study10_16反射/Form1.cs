using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;//引入反射命名空间
using interface_Fuction;

namespace study10_16反射
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //动态加载程序集并创建对象
            IFunction objfunction = (IFunction)Assembly.LoadFrom("Function.dll").CreateInstance("Function.Function");
            int a = Convert.ToInt32(this.textBox1.Text);
            int b = Convert.ToInt32(this.textBox2.Text);
            string result = "0";
            //通过接口完成计算
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    result = objfunction.Add(a, b).ToString();
                    break;
                case 1:
                    result = objfunction.Sub(a, b).ToString();
                    break;
                case 2:
                    result = objfunction.Multiply(a, b).ToString();
                    break;
                case 3:
                    result = objfunction.Division(a, b).ToString();
                    break;
                default:
                    break;
            }
            this.textBox3.Text = result;
        }
    }
}

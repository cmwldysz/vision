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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("密码不正确");
            MessageBox.Show("密码不正确", "登录提示");
            MessageBox.Show("是否重新输入密码", "登录提示", MessageBoxButtons.OKCancel);
            MessageBox.Show("是否重新输入密码", "登录提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            MessageBox.Show("是否重新输入密码", "登录提示", MessageBoxButtons.YesNoCancel);
            DialogResult dialogResult = MessageBox.Show("是否重新输入密码", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                Console.WriteLine("登录成功");
            } 
            else
            {
                Console.WriteLine("登录失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form902 fr2 = new Form902(this);
            DialogResult result = fr2.ShowDialog();
            if (result == DialogResult.OK)
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("登录失败");
            }
            //fr2.Show();
        }
    }
}

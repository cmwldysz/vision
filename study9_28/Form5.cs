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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //关闭嵌入的窗体
        private void ClosePerForm() {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is Form)
                {
                    Form objcontrol = (Form)item;//里氏转换
                    objcontrol.Close();//关闭窗口
                }
            }
        }
        //嵌入窗体创建
        private void OpenForm(Form objForm) {
            ClosePerForm();//关闭之前已经打开的窗体
            objForm.TopLevel = false;//将子窗体设置成非顶级控件
            objForm.Parent = this.panel1;//指定子窗口挂靠显示的容器
            objForm.Dock = DockStyle.Fill;//填充满Panle(画布)模式
            objForm.Show();//显示窗体
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5_01());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5_02());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new Form5_03());
        }
    }
}

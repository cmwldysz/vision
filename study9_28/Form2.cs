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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string information = "您的计算机配置如下：";
            information += "\nCPU：" + this.comboBox1.Text;
            information += "\n内存：";
            //判断是否选中
            if (this.checkedListBox1.CheckedItems.Count > 0)
            {
                foreach (var item in this.checkedListBox1.CheckedItems)
                {
                    information += item.ToString()+"\t";
                }
            }
            else
            {
                information += "您没有选择内存！";
            }
            
            information += "\n配件：";
            //判断是否选中
            if (this.checkedListBox2.CheckedItems.Count > 0)
            {
                foreach (var item in this.checkedListBox2.CheckedItems)
                {
                    information += item.ToString() + "\t";
                }
            }
            else
            {
                information += "您没有选择配件！";
            }
            information += "\n硬盘：";
            if (this.radioButton1.Checked == true)
            {
                information += "500GB";
            }
            else if (this.radioButton2.Checked == true)
            {
                information += "1TB";
            }
            information += "\n显示器：";
            if (this.radioButton6.Checked == true)
            {
                information += "13英寸";
            }
            else if (this.radioButton7.Checked == true)
            {
                information += "14英寸";
            }
            else if (this.radioButton8.Checked == true)
            {
                information += "15英寸";
            }
            MessageBox.Show(information);
        }
    }
}

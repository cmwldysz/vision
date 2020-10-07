using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study10_6
{
    public partial class Form1 : Form
    {
        //1.新建数据类型：DataTable[储存在内存条中的表格数据类型]
        DataTable dt = new DataTable();


        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = dt;//将控件的数据源绑定DataTable
        }
        //创建表头信息
        private void button1_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("学号", typeof(int));
            dt.Columns.Add("姓名", typeof(string));
            dt.Columns.Add("班级", typeof(string));
            dt.Columns.Add("电话号码", typeof(string));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(1, "助教", "语言班", "123-456");
            dt.Rows.Add(2, "龙傲天", "语言班", "123-456");
            dt.Rows.Add(3, "龙嗷嗷", "语言班", "123-456");
            dt.Rows.Add(4, "助教", "语言班", "123-456");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dt.Rows.RemoveAt(2);
            int index = dt.Rows.Count - 1;
            if (index < 0)
            {
                MessageBox.Show("已删除完毕", "提示消息", MessageBoxButtons.OK);
                return;
            }
            for (int i = 0; i < dt.Rows[index].ItemArray.Length; i++)
            {
                Console.Write(dt.Rows[index].ItemArray[i]+" ");
            }
            Console.WriteLine();
            dt.Rows.Remove(dt.Rows[index]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Rows[i].ItemArray.Length; j++)
            //    {
            //        Console.Write(dt.Rows[i].ItemArray[j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            int index = dt.Rows.Count - 1;
            dt.Rows[index][1] = "佳佳";
            dt.Rows[index][2] = "三年二班";
            dt.Rows[index][3] = "089-789";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentCell != null)
            {
                int index = this.dataGridView1.CurrentCell.RowIndex;
                dt.Rows.Remove(dt.Rows[index]);
                //dt.Rows.RemoveAt(index);
            }
        }
    }
}

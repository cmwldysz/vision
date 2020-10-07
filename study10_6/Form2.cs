using _10_6ClassLibrary1;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length > 0)
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息 where 学号=" + this.textBox1.Text);
            }
            else if (this.textBox2.Text.Length > 0)
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息 where 姓名='" + this.textBox2.Text + "'");
            }
            else if (this.textBox3.Text.Length > 0)
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息 where 年龄=" + this.textBox3.Text);
            }
            else if (this.textBox4.Text.Length > 0)
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息 where 性别='" + this.textBox4.Text + "'");
            }
            else if (this.textBox5.Text.Length > 0)
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息 where 电话='" + this.textBox5.Text+"'");
            }
            else
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into 学生信息(姓名,年龄,性别,电话号码)values('{0}',{1},'{2}','{3}')";
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("新增用户名不能为空");
                return;
            }
            sql = string.Format(sql, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.textBox5.Text);
            if (SQLHelper.Updata(sql) > 0)
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息");
                this.clearFrom();
            }
            else {
                MessageBox.Show("新增失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from 学生信息 where 学号={0}";
            if (this.dataGridView1.CurrentCell != null)
            {
                string studentID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = string.Format(sql, studentID);
                if (SQLHelper.Updata(sql) > 0)
                {
                    this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "update 学生信息 set 姓名='{0}',年龄='{1}',性别='{2}',电话号码='{3}' where 学号={4}";
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("学号不能为空");
                return;
            }
            sql = string.Format(sql, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.textBox5.Text,this.textBox1.Text);
            if (SQLHelper.Updata(sql) > 0)
            {
                this.dataGridView1.DataSource = SQLHelper.GetDataTable("select * from 学生信息");
                this.clearFrom();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
        private void clearFrom() {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INI_ClassLibrary;

namespace _10_7EXL表格
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建文件流
            FileStream fs = new FileStream("./myfile.txt",FileMode.Append);
            //创建写入器
            StreamWriter sw = new StreamWriter(fs);
            //以文件流的形式写入数据
            sw.WriteLine(DateTime.Now.ToString() + "[Form2][button1_Click]写入日志");
            //关闭写入器
            sw.Close();
            //关闭文件流
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //创建文件流
            FileStream fs = new FileStream("./myfile.txt", FileMode.Open);
            //创建读取器
            StreamReader sr = new StreamReader(fs);
            //以流的方式读取数据
            this.textBox1.Text = sr.ReadToEnd();
            //关闭写入器
            sr.Close();
            //关闭文件流
            fs.Close();
        }
        //删除
        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(this.textBox2.Text.Trim());
        }
        //复制
        private void button4_Click(object sender, EventArgs e)
        {
            //判断前往的文件夹是否存在同名的文件，如果存在删除对应的文件
            if (File.Exists(this.textBox3.Text.Trim()))
            {
                File.Delete(this.textBox3.Text.Trim());
            }
            //复制新的文件到目标文件夹当中
            File.Copy(this.textBox2.Text.Trim(), this.textBox3.Text.Trim());
        }
        //移动
        private void button5_Click(object sender, EventArgs e)
        {
            File.Move(this.textBox2.Text.Trim(), this.textBox3.Text.Trim());
        }
        //保存配置
        private void button10_Click(object sender, EventArgs e)
        {
            //保存绝对路径
            string Save_File = System.AppDomain.CurrentDomain.BaseDirectory + "日志记录.ini";

            INI.WritePrivateProfileString("日志配置", "源文件路径", @"D:\work\offect\text1\myfile.txt", Save_File);
            INI.WritePrivateProfileString("日志配置", "目的文件路径", @"D:\work\offect\text2\myfile.txt", Save_File);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //string Save_File = System.AppDomain.CurrentDomain.BaseDirectory + "日志记录.ini";
            //this.textBox2.Text = INI.ContentValue("日志配置", "源文件路径", Save_File);
            //this.textBox2.Text = INI.ContentValue("日志配置", "目的文件路径", Save_File);
        }
        //显示指定目录下的所有文件
        private void button6_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"D:\work\offect\");
            this.textBox1.Text = "";
            foreach (string item in files)
            {
                this.textBox1.Text += item + "\r\n";
            }
        }
        //显示指定目录下的所有子目录
        private void button7_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetDirectories(@"D:\work\offect");
            this.textBox1.Text = "";
            foreach (string item in files)
            {
                this.textBox1.Text += item + "\r\n";
            }
        }
        //指定目录下创建一个子目录
        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                Directory.CreateDirectory(@"D:\work\offect\"+i.ToString());
            }
        }
        //删除指定目录下的所有子目录和文件 
        private void button9_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\work\offect");
            dir.Delete(true);
        }
    }
}

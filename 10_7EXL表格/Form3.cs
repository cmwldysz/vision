using CSV_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_7EXL表格
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        //csv写入
        private void button1_Click(object sender, EventArgs e)
        {
            //规定写入的路径
            string path = "学生信息.csv";
            //第一行内容
            string[] rowCells_1 = new string[4];
            //每一个格子的内容写入
            rowCells_1[0] = "学号";
            rowCells_1[1] = "姓名";
            rowCells_1[2] = "班级";
            rowCells_1[3] = "籍贯";
            //第二行内容
            string[] rowCells_2 = new string[4];
            //每一个格子的内容写入
            rowCells_2[0] = "001";
            rowCells_2[1] = "助教";
            rowCells_2[2] = "语言班";
            rowCells_2[3] = "东莞";
            //存入
            List<string[]> rowList_Write = new List<string[]>();
            //添加每一行的内容
            rowList_Write.Add(rowCells_1);
            rowList_Write.Add(rowCells_2);
            //写入CSV当中最后一个是不追加，覆盖式写入
            CSV_ClassLibrary.CSV.WriteCSV(path, rowList_Write, false);
        }
        //csv读取
        private void button2_Click(object sender, EventArgs e)
        {
            List<string[]> rowList_Write = CSV.ReadCSV("学生信息.csv");
            for (int i = 0; i < rowList_Write.Count; i++)
            {
                for (int j = 0; j < rowList_Write[i].Length; j++)
                {
                    Console.Write(rowList_Write[i][j]+"  ");
                }
                Console.WriteLine();
            }
        }
        //xml写入
        private void button3_Click(object sender, EventArgs e)
        {
            //初始化XML
            XmlConfigUtil util = new XmlConfigUtil("1.xml");
            util.Write(this.textBox1.Text, "information", "name");
            util.Write(this.textBox2.Text, "information", "class");
            util.Write(this.textBox3.Text, "information", "sex");
            util.Write(this.textBox4.Text, "information", "year");

            util.Write(this.textBox1.Text, "information2", "name");
            util.Write(this.textBox2.Text, "information2", "class");
            util.Write(this.textBox3.Text, "information2", "sex");
            util.Write(this.textBox4.Text, "information2", "year");

            util.Write(this.textBox1.Text, "name");
            util.Write(this.textBox2.Text,  "class");
            util.Write(this.textBox3.Text, "sex");
            util.Write(this.textBox4.Text, "year");

        }
        //XML读取
        private void button4_Click(object sender, EventArgs e)
        {
            XmlConfigUtil util = new XmlConfigUtil("1.xml");
            this.textBox1.Text = util.Read("information", "name");
            this.textBox2.Text = util.Read("information", "class");
            this.textBox3.Text = util.Read("information", "sex");
            this.textBox4.Text = util.Read("information", "year");
        }
        //序列化与反序列化：序列化->将内存中的对象（数据）保存成硬盘上的文件
        //二进制文件          ：反序列化->将硬盘中的文件加载到内存当中
        // Serializable标记可以进行序列化写入文件到内存当中
        [Serializable]
        public class Student {
            private string studentName;
            private int age;
            private string gender;
            private string year;

            public string StudentName { get => studentName; set => studentName = value; }
            public int Age { get => age; set => age = value; }
            public string Gender { get => gender; set => gender = value; }
            public string Year { get => year; set => year = value; }
        }
        //序列化
        private void button6_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                StudentName = this.textBox8.Text,
                Age = Convert.ToInt32(this.textBox7.Text),
                Gender = this.textBox6.Text,
                Year = this.textBox5.Text
            };
            //1.创建文件流
            FileStream fs = new FileStream("objStudent.stu",FileMode.Create);
            //2.创建二进制格式转换器
            BinaryFormatter formatter = new BinaryFormatter();
            //3.调用序列化方法
            formatter.Serialize(fs, student);
            //4.关闭文件流
            fs.Close();
        }
        //反序列化
        private void button5_Click(object sender, EventArgs e)
        {
            //1.创建文件流
            FileStream fs = new FileStream("objStudent.stu", FileMode.Open);
            //2.创建二进制格式转换器
            BinaryFormatter formatter = new BinaryFormatter();
            //3.调用反序列化方法
            Student objstudent = (Student)formatter.Deserialize(fs);
            //4.关闭文件流
            fs.Close();
            this.textBox8.Text = objstudent.StudentName;
            this.textBox7.Text = objstudent.Age.ToString();
            this.textBox6.Text = objstudent.Gender;
            this.textBox5.Text = objstudent.Year;
        }
    }
}

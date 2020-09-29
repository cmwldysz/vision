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

namespace study9_28
{
    
    public partial class Form3 : Form
    {
        //中间变量
        int count = 0;
        string[] ImageUrls;
        public Form3()
        {
            InitializeComponent();
        }
        //窗体加载事件：在主窗体显示之前的操作
        private void Form3_Load(object sender, EventArgs e)
        {
           //获取文件路径集合
            ImageUrls = Directory.GetFiles(@"D:\work\vs\study\access");
            this.pictureBox1.ImageLocation = ImageUrls[0];
        }
        //上一张
        private void button1_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                this.pictureBox1.ImageLocation = ImageUrls[--count];
            }
            else
            {
                count = ImageUrls.Length-1;
                this.pictureBox1.ImageLocation = ImageUrls[count];
            }
        }
        //下一张
        private void button2_Click(object sender, EventArgs e)
        {
            if (count < ImageUrls.Length-1)
            {
                this.pictureBox1.ImageLocation = ImageUrls[++count];
            }
            else {
                count = 0;
                this.pictureBox1.ImageLocation = ImageUrls[count];
            }
        }
    }
}

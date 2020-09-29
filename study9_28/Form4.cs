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
    public partial class Form4 : Form
    {
        Random rnum;
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = rnum.Next(0, 9).ToString();
            this.label2.Text = rnum.Next(0, 9).ToString();
            this.label3.Text = rnum.Next(0, 9).ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            rnum = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}

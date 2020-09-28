using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study9_25winfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button2.Click += new System.EventHandler(this.button2_Click);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("中午好");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button2.Click -= new System.EventHandler(this.button2_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

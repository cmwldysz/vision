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
    public partial class Form902 : Form
    {
        Form9 form9;
        //创建Form9的类对象
        public Form902()
        {
            InitializeComponent();
        }
        public Form902(Form9 fr1):this()
        {
          this.form9 = fr1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //Form fr2 = new Form903(form9);
            //fr2.Show();
            Form903 fr3 = new Form903(this.form9);
            fr3.Show();
        }
    }
}

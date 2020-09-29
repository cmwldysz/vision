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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.Text = "新建文本";
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "文档";
            //*.rtf文件
            openFile.Filter = "rtf files (*.rtf)|*.rtf";//过滤RTF尾缀的文件
            openFile.RestoreDirectory = true;//还原为之前的选定目录
            if (openFile.ShowDialog() == DialogResult.OK)//点击确定按钮
            {
                this.richTextBox1.LoadFile(openFile.FileName);//加载文件
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "文档";
            saveFile.Filter = "rtf files (*.rtf)|*.rtf";//过滤RTF尾缀的文件
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 剪贴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;//高亮显示文本内容
            fontDialog.Font = richTextBox1.SelectionFont;//设置样式
            fontDialog.Color = richTextBox1.SelectionColor;//设置颜色
            if (fontDialog.ShowDialog() != DialogResult.Cancel) //判断是否更新
            {
                richTextBox1.SelectionFont = fontDialog.Font;//设置字体
                richTextBox1.SelectionColor = fontDialog.Color;//设置颜色
            }
        }
    }
}

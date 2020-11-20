using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study10_16串口通信
{
    public partial class Form1 : Form
    {
        //全局变量用来判断是否打开串口
        bool m_p = true;
        //创建串口类的对象
        SerialPort sp = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //设置COM默认选中的下拉框
            this.cmbPoint.SelectedIndex = 3;
            //波特率
            this.cmbBauRaudRate.SelectedIndex = 1;
            //设置数据位
            this.cmbDataBits.SelectedIndex = 1;
            //设置停止位
            this.cmbStopBit.SelectedIndex = 0;
            //设置奇偶校验位
            this.cmbParity.SelectedIndex = 0;
        }
        //打开串口
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //判断是否发开串口的端口
                if (m_p)
                {
                    this.button1.Text = "关闭端口";
                    //设定串口对象的参数
                    sp.PortName = this.cmbPoint.Text;
                    //设置波特率
                    sp.BaudRate = int.Parse(this.cmbBauRaudRate.Text);
                    //设置数据位
                    sp.DataBits = int.Parse(this.cmbDataBits.Text);
                    //设置停止位
                    sp.StopBits = (StopBits)int.Parse(this.cmbStopBit.Text);
                    //打开端口
                    sp.Open();
                    //绑定事件-接收返回消息
                    sp.DataReceived += new SerialDataReceivedEventHandler(sp_DtatReceiver);

                    //关闭端口
                    m_p = false;
                }
                else
                {
                    this.button1.Text = "打开串口";
                    //关闭端口
                    sp.Close();
                    m_p = true;
                }
            }
            catch (Exception ex)
            {
                this.button1.Text = "打开串口";
                MessageBox.Show(ex.Message.ToString()); ;
            }
        }
        void sp_DtatReceiver(object sender,SerialDataReceivedEventArgs e) {
            //将接收到的字节转换成字符串在窗口中显示
            int count = sp.BytesToRead;//获取字符串长度
            byte[] RecieveBuf = new byte[count];//构建缓存数组
            //读取字符串
            sp.Read(RecieveBuf, 0, count);
            //直接转换成字符串的形式
            string strRecieve = Encoding.Default.GetString(RecieveBuf);
            //判断是字符串还是16进制显示
            if (this.radioButton1.Checked == true)//字符串显示
            {
                //跨线程访问空间显示结果
                this.Invoke(new MethodInvoker(delegate () {
                    this.textBox1.Text += ByteToHexStr(RecieveBuf);//添加结果
                }));
            }
            if (this.radioButton2.Checked == true)//字符串显示
            {
                //跨线程访问空间显示结果
                this.Invoke(new MethodInvoker(delegate () {
                    this.textBox1.Text += strRecieve;//添加结果
                }));
            }
        }
        //转字符串显示
        public static string ByteToHexStr(byte[] bytes) {
            string returnStr = "";//构建拼接字符串
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)//遍历每个Byte字符转换成16进制字符串
                {
                    returnStr += bytes[i].ToString("X2");//追加拼接字符串
                }
            }
            return returnStr;//返回对应的字符串
        }

        void run(string str)
        {
            if (sp.IsOpen)//判断串口是否已经打开
            {
                //发送字符串
                if (radioButton2.Checked)
                {
                    byte[] SendBuf = new byte[1024 * 1024];
                    SendBuf = Encoding.Default.GetBytes(str);
                    //发送
                    sp.Write(SendBuf, 0, SendBuf.Length);
                }
                //发送16进制
                if (this.radioButton1.Checked)
                {
                    //将字符串转换16进制的BUYR数值
                    byte[] d = strHexByte(str.Trim());
                    //写入
                    sp.Write(d, 0, d.Length);
                }
            }
            else
            {
                MessageBox.Show("请打开串口！", "警告提示");
            }
        }
        private byte[] strHexByte(string hexString)
        {
            //去除空格
            hexString = hexString.Replace(" ", "");
            //如果不能被2整除后面接上“”，【16进制能被2整除】
            if ((hexString.Length % 2) != 0)
            {
                hexString += " ";
            }
            //
            byte[] returnByte = new byte[hexString.Length / 2];
            //转成16进制
            for (int i = 0; i < returnByte.Length; i++)
            {
                returnByte[i] = Convert.ToByte(hexString.Substring(i*2,2).Replace(" ",""),16);
            }
            //returnByte = Encoding.Default.GetBytes(hexString);
            return returnByte;
        }
        //发送
        private void button7_Click(object sender, EventArgs e)
        {
            run(this.textBox2.Text);
        }
        //停止运动 抬起鼠标
        private void StopRun(object sender, MouseEventArgs e)
        {
            run("FF 01 00 00 00 00 01");
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            //run("FF 01 00 08 00 20 29");//向上
            run("FF 01 00 20 00 00 21");//近郊
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            //run("FF 01 00 10 00 20 31");//向下
            run("FF 01 00 40 00 00 41");//远郊
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            run("FF 01 00 04 20 00 25");//向左
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            run("FF 01 00 02 20 00 23");//向右
            //run("FF 01 00 20 00 00 21");//近郊
            //run("FF 01 00 40 00 00 41");//远郊
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = this.textBox2.Text;
            string str2 = "";
            string str3 = "";

            //去除空格
            str = str.Replace(" ", "");
            //如果不能被2整除后面接上“”，【16进制能被2整除】
            if ((str.Length % 2) != 0)
            {
                str += " ";
            }
            //
            byte[] returnByte = new byte[str.Length / 2];
            //转成16进制
            for (int i = 0; i < returnByte.Length; i++)
            {
                str2 += Convert.ToByte(str.Substring(i * 2, 2).Replace(" ", ""), 16) + "  ";
                str3 += str.Substring(i * 2, 2).Replace(" ", "") + "  ";
            }
            byte[] returnByte2 = new byte[str.Length / 2];
            //转成16进制
            for (int i = 0; i < returnByte2.Length; i++)
            {
                returnByte2[i] = Convert.ToByte(str.Substring(i * 2, 2).Replace(" ", ""), 16);
            }
            string returnStr = "";//构建拼接字符串
            if (returnByte2 != null)
            {
                for (int i = 0; i < returnByte2.Length; i++)//遍历每个Byte字符转换成16进制字符串
                {
                    returnStr += returnByte2[i].ToString("X2");//追加拼接字符串
                }
            }
            Console.WriteLine("16进制：{0}", str2);
            Console.WriteLine("16进制str3：{0}", str3);
            Console.WriteLine("returnByte2：{0}", returnStr);
        }
    }
}

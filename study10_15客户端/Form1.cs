using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study10_15客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //全局对象
        Socket _CllentSocket;
        private void button1_Click(object sender, EventArgs e)
        {
            //拿到IP地址还有端口号
            string _serverIP = this.textBox1.Text;
            string _serverPort = this.textBox2.Text;
            //初始化Socket（全局）对象
            //AddressFamily.InterNetwork        使用IP4协议
            //SocketType.Stream                         支持双向字节流
            //ProtocolType.Tcp                          TCP协议

            _CllentSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //将拿到的字符串转换成IP地址与端口
            IPAddress IP = IPAddress.Parse(_serverIP);
            int Port = Convert.ToInt32(_serverPort);
            //形成IP地址与端口号
            IPEndPoint IPEnd = new IPEndPoint(IP, Port);
            //连接IP地址与端口号
            try
            {
                _CllentSocket.Connect(IPEnd);
                this.textBox3.Text = "连接服务器成功";
            }
            catch (Exception)
            {
                this.textBox3.Text = "连接服务器失败！！！";
            }
            //创建线程用以接收数据
            Thread GetMessageThread = new Thread(ReceiveMessage);
            GetMessageThread.IsBackground = true;
            GetMessageThread.Start();
        }
        //接收结果缓存
        private static byte[] _result = new byte[1024];
        //接收消息的函数
        public void ReceiveMessage() {
            while (true)
            {
                //接收ClientSocket对象
                int recelivelength = _CllentSocket.Receive(_result);
                //判断长度内容
                if (recelivelength>0)
                {
                    //拼接字符串
                    string str = string.Format("{0} 接收服务器消息：{1} \r\n",DateTime.Now.ToString(),Encoding.UTF8.GetString(_result,0,recelivelength));
                    //显示内容
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        this.textBox3.Text += "\r\n" + str;
                    }));
                }
            }
        }
        //发送
        private void button2_Click(object sender, EventArgs e)
        {
            //获取要发送的内容
            string SendMessage = this.textBox4.Text;
            //向服务器发送对应的内容
            _CllentSocket.Send(Encoding.UTF8.GetBytes(SendMessage));
        }
    }
}

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

namespace study10_15TCP
{
    public partial class Form1 : Form
    {
        //创建全局变量
        public Socket _ServerSocket;
        public Form1()
        {
            InitializeComponent();
        }
        //启动服务
        private void button1_Click(object sender, EventArgs e)
        {
            //拿到IP地址和端口号
            string _serverIP = this.textBox1.Text;
            string _severPort = this.textBox2.Text;
            //初始化Socket(全局性)对象
            //AddressFamily.InterNetwork        使用IP4协议
            //SocketType.Stream     支持双向字节流
            //ProtocolType.Tcp      使用TCP协议
            _ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //将拿到的字符串转换成IP地址与端口号
            IPAddress IP = IPAddress.Parse(_serverIP);
            int Port = Convert.ToInt32(_severPort);
            //初始化形成IP地址
            IPEndPoint iPEnd = new IPEndPoint(IP,Port);

            //设置Scoke属性
            _ServerSocket.Bind(iPEnd);//绑定IP地址与端口号
            _ServerSocket.Listen(10);//设定监听最多10个客户端

            //提示启动服务器成功
            this.listBox1.Items.Add("启动服务器成功！");
            //启动监控线程，用以监听是否有客户端连接过来(鉴于接待大厅的作用)
            Thread listenThread = new Thread(ListenClientConnect);
            listenThread.IsBackground = true;//后台线程
            listenThread.Start();//线程启动

        }
        //定义一个用于实现监听的全局变量
        Socket clientSocket;
        //创建一个字典用于接收连接过来的客户端IP与对象
        Dictionary<string, Socket> ascok = new Dictionary<string, Socket>();
        public void ListenClientConnect() {
            while (true)
            {
                //会对当前线程一直阻塞知道客户端连接过来【客户端连接过来时解除线程阻塞】
                clientSocket  = _ServerSocket.Accept();//引发线程阻塞
                //如果能到这一步，说明以偶客户端连接过来，此时利用字典保存对象与名称
                ascok.Add(clientSocket.RemoteEndPoint.ToString(),clientSocket);
                //往下拉列表中添加IP：端口号 => 用以后面的选择客户端发送消息
                this.comboBox1.Items.Add(clientSocket.RemoteEndPoint.ToString());
                //往消息列表中添加行内容
                this.listBox1.Items.Add(clientSocket.RemoteEndPoint.ToString()+"连接成功");
                //发送消息给连接上的客户端，提示已经连接上服务器
                clientSocket.Send(Encoding.UTF8.GetBytes("成功连接上服务器！"));
                //启动会话线程用户接受发送消息
                Thread ReceiveThread = new Thread(RecelveMessage);
                ReceiveThread.IsBackground = true;
                ReceiveThread.Start(clientSocket);
            }
        }
        //创建全局缓存变量
        private static byte[] _result = new byte[1024];
        //线程的功能函数=>回复与发送
        public void RecelveMessage(object clientSocket) {
            //转换Socket  里氏转换
            Socket myClientSocket = (Socket)clientSocket;
            while (true)
            {
                //当连接出现问题的时候需要进行处理
                try
                {
                    //通过 myClientSocket 接收数据
                    int resultNumber = myClientSocket.Receive(_result);
                    //判断接收的长度是否大于0，如果小于0说明没有内容
                    if (resultNumber > 0)
                    {
                        //拼接字符串，形成消息
                        string str = string.Format("接收客户端{0} 消息{1} \r\n", myClientSocket.RemoteEndPoint.ToString(), Encoding.UTF8.GetString(_result, 0, resultNumber));
                        //添加到消息列表当中
                        this.listBox1.Items.Add(str);

                    }
                }
                catch (Exception ex)
                {
                    //输出可能的错误提示,打印和弹窗两种方式，弹窗会影响线程
                    MessageBox.Show(ex.Message.ToString(),"错误提示");
                    Console.WriteLine("错误：{0}", ex.Message);
                    //关闭Socket对象
                    myClientSocket.Close();
                }

            }
        }
        //停止服务
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //发送消息
        private void button3_Click(object sender, EventArgs e)
        {
            //获取IP的地址
            string IPandPort = this.comboBox1.SelectedItem.ToString();
            //获取要发送的内容：消息编辑框
            string SendMessage = this.textBox3.Text;
            Console.WriteLine("发送消息："+ SendMessage);
            //发送消息 - 字典中获取对象然后发送
            ascok[IPandPort].Send(Encoding.UTF8.GetBytes(SendMessage));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //关闭跨线程访问限制   能自由访问空间
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //清空
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }
    }
}

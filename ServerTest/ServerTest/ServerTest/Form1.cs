using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTest
{
    struct ClientInfo
    {
        public EndPoint epPoint;
        public string name;    //客户端昵称
    }

    public partial class Form1 : Form
    {
        public static bool isOpen = true;
        // 创建一个和客户端通信的套接字
        static Socket socketwatch = null;
        //定义一个集合，存储客户端信息
        static Dictionary<string, Socket> clientConnectionItems = new Dictionary<string, Socket> { };

        static Socket curSocket = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定义一个套接字用于监听客户端发来的消息，包含三个参数（IP4寻址协议，流式连接，Tcp协议）  
            socketwatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息需要一个IP地址和端口号  
            IPAddress address = IPAddress.Parse("127.0.0.1");
            //将IP地址和端口号绑定到网络节点point上  
            IPEndPoint point = new IPEndPoint(address, 8098);
            //此端口专门用来监听的  

            //监听绑定的网络节点  
            socketwatch.Bind(point);

            //将套接字的监听队列长度限制为20  
            socketwatch.Listen(20);

            //负责监听客户端的线程:创建一个监听线程  
            Thread threadwatch = new Thread(watchconnecting);

            //将窗体线程设置为与后台同步，随着主线程结束而结束  
            threadwatch.IsBackground = true;

            //启动线程     
            threadwatch.Start();

            MessageBox.Show("开启监听。。。");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {
                //创建一个内存缓冲区，其大小为1024*1024字节  即1M     
                byte[] arrServerRecMsg = new byte[1024 * 1024];
                //将接收到的信息存入到内存缓冲区，并返回其字节数组的长度    
                try
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        // 因为头部消息有8字节长度，所以先跳过8字节

                        byte[] bytes = new byte[] { 0x04, 0x00, 0x00, 0x00, 0x08, 0x0a, 0x10, 0x1e, 0x1a, 0x00, 0x00, 0x00, 0x0a, 0x18, 0xe5, 0xae, 0xa2, 0xe6, 0x88, 0xb7, 0xe7, 0xab, 0xaf, 0xe4, 0xbd, 0xa0, 0xe5, 0xa5, 0xbd, 0x2e, 0x2e, 0x2e, 0xe8, 0xb0, 0x83, 0xe7, 0x9a, 0xae };
                        //byte[] bytes = new byte[] { 0x0f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xa3, 0x3f, 0x00, 0x00, 0x00, 0x24, 0x40 };
                        curSocket.Send(bytes);
                    }
                }
                catch (Exception ex)
                {
                    clientConnectionItems.Remove(curSocket.RemoteEndPoint.ToString());

                    MessageBox.Show("Client Count:" + clientConnectionItems.Count);

                    //提示套接字监听异常  
                    MessageBox.Show("客户端" + curSocket.RemoteEndPoint + "已经中断连接" + "\r\n" + ex.Message + "\r\n" + ex.StackTrace + "\r\n");
                    //关闭之前accept出来的和客户端进行通信的套接字 
                    curSocket.Close();
                }
            }
        }
        static void recv(object socketclientpara)
        {
            curSocket = socketclientpara as Socket;
        }

        //监听客户端发来的请求  
        static void watchconnecting()
        {
            Socket connection = null;

            //持续不断监听客户端发来的请求     
            while (true)
            {
                try
                {
                    connection = socketwatch.Accept();
                }
                catch (Exception ex)
                {
                    //提示套接字监听异常     
                    MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                //获取客户端的IP和端口号  
                IPAddress clientIP = (connection.RemoteEndPoint as IPEndPoint).Address;
                int clientPort = (connection.RemoteEndPoint as IPEndPoint).Port;

                //客户端网络结点号  
                string remoteEndPoint = connection.RemoteEndPoint.ToString();
                //显示与客户端连接情况
                //MessageBox.Show("成功与" + remoteEndPoint + "客户端建立连接！");
                //添加客户端信息  
                clientConnectionItems.Add(remoteEndPoint, connection);

                //IPEndPoint netpoint = new IPEndPoint(clientIP,clientPort); 
                IPEndPoint netpoint = connection.RemoteEndPoint as IPEndPoint;

                //创建一个通信线程      
                ParameterizedThreadStart pts = new ParameterizedThreadStart(recv);
                Thread thread = new Thread(pts);
                //设置为后台线程，随着主线程退出而退出 
                thread.IsBackground = true;
                //启动线程     
                thread.Start(connection);
            }
        }

    }
}

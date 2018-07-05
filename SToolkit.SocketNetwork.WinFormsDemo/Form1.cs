using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SToolkit.SocketNetwork.WinFormsDemo
{
    public partial class Form1 : Form
    {
        SocketServer TcpServer { get; set; }
        SocketServer UdpServer { get; set; }
        SocketClient TcpClient { get; set; }
        SocketClient UdpClient { get; set; }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void TcpStart_Click(object sender, EventArgs e)
        {
            TcpServer = new SocketServer(NetworkType.Tcp, IPAddress.Parse(TcpServerIP.Text), int.Parse(TcpServerPort.Text));
            TcpServer.OnStart += (s, ev) =>
            {
                TcpServerLog.Text += $"Server started\n";
            };
            TcpServer.OnStop += (s, ev) =>
            {
                TcpServerLog.Text += $"Server stopped\n";
            };
            TcpServer.OnConnected += (s, ev) =>
            {
                TcpServerLog.Text += $"Connected from {ev.Client.RemoteIP}:{ev.Client.RemotePort}\n";
            };
            TcpServer.OnDisconnected += (s, ev) =>
            {
                TcpServerLog.Text += $"Disconnected from {ev.Client.RemoteIP}:{ev.Client.RemotePort}\n";
            };
            TcpServer.OnReceived += (s, ev) =>
            {
                TcpServerLog.Text += $"Recieved {Encoding.Default.GetString(ev.Data)} from {ev.Client.RemoteIP}:{ev.Client.RemotePort}\n";
                ev.Client.Send(ev.Data);
            };
            TcpServer.Start();
        }

        private void TcpStop_Click(object sender, EventArgs e)
        {
            TcpServer.Stop();
        }

        private void TcpConnect_Click(object sender, EventArgs e)
        {
            TcpClient = new SocketClient(NetworkType.Tcp);
            TcpClient.OnConnected += (s, ev) =>
            {
                TcpClientLog.Text += $"Connected to {TcpClient.RemoteIP}:{TcpClient.RemotePort}\n";
            };
            TcpClient.OnDisconnected += (s, ev) =>
            {
                TcpClientLog.Text += $"Disconnected\n";
            };
            TcpClient.OnReceived += (s, ev) =>
            {
                TcpClientLog.Text += $"Received {Encoding.Default.GetString(ev.Data)}\n";
            };
            TcpClient.Connect(new IPEndPoint(IPAddress.Parse(TcpClientIP.Text), int.Parse(TcpClientPort.Text)));
        }

        private void TcpDisconnect_Click(object sender, EventArgs e)
        {
            TcpClient.Disconnect();
        }

        private void TcpSend_Click(object sender, EventArgs e)
        {
            TcpClient.Send(Encoding.Default.GetBytes(TcpData.Text));
        }

        private void UdpStart_Click(object sender, EventArgs e)
        {
            UdpServer = new SocketServer(NetworkType.Udp, IPAddress.Parse(UdpServerIP.Text), int.Parse(UdpServerPort.Text));
            UdpServer.OnStart += (s, ev) =>
            {
                UdpServerLog.Text += $"Server started\n";
            };
            UdpServer.OnStop += (s, ev) =>
            {
                UdpServerLog.Text += $"Server stopped\n";
            };
            UdpServer.OnConnected += (s, ev) =>
            {
                UdpServerLog.Text += $"Connected from {ev.Client.RemoteIP}:{ev.Client.RemotePort}\n";
            };
            UdpServer.OnDisconnected += (s, ev) =>
            {
                UdpServerLog.Text += $"Disconnected from {ev.Client.RemoteIP}:{ev.Client.RemotePort}\n";
            };
            UdpServer.OnReceived += (s, ev) =>
            {
                UdpServerLog.Text += $"Recieved {Encoding.Default.GetString(ev.Data)} from {ev.Client.RemoteIP}:{ev.Client.RemotePort}\n";
                ev.Client.Send(ev.Data);
            };
            UdpServer.Start();
        }

        private void UdpStop_Click(object sender, EventArgs e)
        {
            UdpServer.Stop();
        }

        private void UdpConnect_Click(object sender, EventArgs e)
        {
            UdpClient = new SocketClient(NetworkType.Udp);
            UdpClient.OnConnected += (s, ev) =>
            {
                UdpClientLog.Text += $"Connected to {UdpClient.RemoteIP}:{UdpClient.RemotePort}\n";
            };
            UdpClient.OnDisconnected += (s, ev) =>
            {
                UdpClientLog.Text += $"Disconnected\n";
            };
            UdpClient.OnReceived += (s, ev) =>
            {
                UdpClientLog.Text += $"Received {Encoding.Default.GetString(ev.Data)}\n";
            };
            UdpClient.Connect(new IPEndPoint(IPAddress.Parse(UdpClientIP.Text), int.Parse(UdpClientPort.Text)));
        }

        private void UdpDisconnect_Click(object sender, EventArgs e)
        {
            UdpClient.Disconnect();
        }

        private void UdpSend_Click(object sender, EventArgs e)
        {
            UdpClient.Send(Encoding.Default.GetBytes(UdpData.Text));
        }
    }
}

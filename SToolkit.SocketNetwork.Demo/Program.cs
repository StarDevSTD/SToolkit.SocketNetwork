using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SToolkit.SocketNetwork.Demo
{
    class Program
    {
        static SocketServer TcpServer { get; set; }
        static SocketServer UdpServer { get; set; }

        static void Main(string[] args)
        {
            //TcpServer = new SocketServer(NetworkType.Tcp, IPAddress.Loopback, 5400);
            //TcpServer.OnConnected += UdpServer_OnConnected;
            //TcpServer.OnDisconnected += UdpServer_OnDisconnected;
            //TcpServer.OnError += UdpServer_OnError;
            //TcpServer.OnReceived += UdpServer_OnReceived;
            //TcpServer.OnStart += UdpServer_OnStart;
            //TcpServer.OnStop += UdpServer_OnStop;
            //Console.WriteLine("Starting tcp server");
            //TcpServer.Start();
            //SocketClient TcpClient = new SocketClient(NetworkType.Tcp);
            //TcpClient.OnConnected += TcpClient_OnConnected;
            //TcpClient.OnDisconnected += TcpClient_OnDisconnect;
            //TcpClient.OnReceived += TcpClient_OnReceived;
            //TcpClient.Connect(IPAddress.Loopback, 5400);
            //TcpClient.Disconnect();
            //TcpServer.Stop();

            UdpServer = new SocketServer(NetworkType.Udp, IPAddress.Loopback, 5401);
            UdpServer.OnConnected += UdpServer_OnConnected;
            UdpServer.OnDisconnected += UdpServer_OnDisconnected;
            UdpServer.OnError += UdpServer_OnError;
            UdpServer.OnReceived += UdpServer_OnReceived;
            UdpServer.OnStart += UdpServer_OnStart;
            UdpServer.OnStop += UdpServer_OnStop;
            Console.WriteLine("Starting udp server");
            UdpServer.Start();
            SocketClient UdpClient = new SocketClient(NetworkType.Udp);
            UdpClient.OnConnected += TcpClient_OnConnected;
            UdpClient.OnDisconnected += TcpClient_OnDisconnect;
            UdpClient.OnReceived += TcpClient_OnReceived;
            UdpClient.Connect(IPAddress.Loopback, 5401);
            Console.ReadKey();
            for (int i = 0; i < 100000; ++i)
            {
                UdpClient.Socket.Send(Encoding.Default.GetBytes($"Hello my dear friends {i}"));
                Thread.Sleep(1);
            }
            Console.ReadKey();
            UdpClient.Disconnect();
            Console.ReadKey();
            UdpServer.Stop();
            Console.ReadKey();
        }

        private static void TcpClient_OnReceived(object sender, SocketClientEventArgs e)
        {
            Console.WriteLine($"[UDPClient] recieved {e.Data.Length}");
            Console.WriteLine($"[UDPClient] {Encoding.Default.GetString(e.Data)}");
        }

        private static void TcpClient_OnDisconnect(object sender, EventArgs e)
        {
            Console.WriteLine($"[UDPClient] disconnected");
        }

        private static void TcpClient_OnConnected(object sender, EventArgs e)
        {
            Console.WriteLine($"[UDPClient] connected");
        }

        private static void UdpServer_OnStop(object sender, EventArgs e)
        {

        }

        private static void UdpServer_OnStart(object sender, EventArgs e)
        {

        }

        private static void UdpServer_OnReceived(object sender, SocketServerDataEventArgs e)
        {
            Console.WriteLine($"[UDPServer]Recieved from {e.Client.Socket.RemoteEndPoint.ToString()}, len {e.Data.Length}");
            e.Client.Send(e.Data);
        }

        private static void UdpServer_OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine($"[UDPServer]Error {e.GetException().ToString()}");
        }

        private static void UdpServer_OnDisconnected(object sender, SocketServerClientEventArgs e)
        {
            Console.WriteLine($"[UDPServer]Disconnected from {e.Client.RemoteIP}:{e.Client.RemotePort}");
        }

        private static void UdpServer_OnConnected(object sender, SocketServerClientEventArgs e)
        {
            Console.WriteLine($"[UDPServer]New client {e.Client.RemoteIP}:{e.Client.RemotePort}");
        }
    }
}

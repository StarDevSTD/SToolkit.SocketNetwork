using System;

namespace SToolkit.SocketNetwork
{
    public class SocketClientEventArgs : EventArgs
    {
        public byte[] Data { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SToolkit.SocketNetwork
{
    public class SocketClientEventArgs : EventArgs
    {
        public byte[] Data { get; set; }
    }
}

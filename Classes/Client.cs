using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ClientMesseger.Classes
{
    class Client
    {
        private string hostname;
        private int port;

        private TcpClient client;
        private NetworkStream ns;

        private int ServerConnect()
        {
            client = new TcpClient();
            client.Connect(hostname, port);
            ns = client.GetStream();
            string str = "Hello from Client!";
            byte[] bstr = System.Text.Encoding.ASCII.GetBytes(str);
            ns.Write(bstr, 0, bstr.Length);
            return 0;
        }

        public Client(string hostname, int port)
        {
            this.hostname = hostname;
            this.port = port;
            ServerConnect();
        }

        ~Client()
        {
            client?.Close();
        }
    }
}

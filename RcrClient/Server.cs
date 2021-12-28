using System.Net;

namespace RcrClient
{
    public class Server
    {
        public IPAddress Ip { get; set; }

        public bool Enabled { get; set; } = true;

        public override string ToString()
        {
            return Ip.ToString();
        }
    }
}
using System;

namespace NCatTelnetTool.Models
{
    public class ConnectionInfo
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public bool IsConnected { get; set; }

        public ConnectionInfo()
        {
            Port = 23;
            IsConnected = false;
        }

        public ConnectionInfo(string name, string host, int port)
        {
            Name = name;
            Host = host;
            Port = port;
            IsConnected = false;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}:{2})", Name, Host, Port);
        }
    }
}

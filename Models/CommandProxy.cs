using System;

namespace NCatTelnetTool.Models
{
    public class CommandProxy
    {
        public string ChineseName { get; set; }
        public string Command { get; set; }

        public CommandProxy()
        {
        }

        public CommandProxy(string chineseName, string command)
        {
            ChineseName = chineseName;
            Command = command;
        }

        public override string ToString()
        {
            return ChineseName;
        }
    }
}

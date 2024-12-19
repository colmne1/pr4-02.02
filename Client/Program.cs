using System;
using System.Collections.Generic;
using System.Net;

namespace Client
{
    internal class Program
    {
        public static IPAddress IPAddress = IPAddress.Parse("127.0.0.1");
        public static int Port = 5000;
        public static List<string> folders = new List<string>();
        public static int Id = -1;
    }
}

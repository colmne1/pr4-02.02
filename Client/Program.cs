﻿using System;
using System.Collections.Generic;
using System.Net;

namespace Client
{
    public class Program
    {
        public static IPAddress IPAddress = IPAddress.Parse("127.0.0.1");
        public static int Port = 5000;
        public static List<string> folders = new List<string>();
        public static int Id = -1;
    }
    public static bool CheckCommand(string message)
    {
        bool BCommand = false;
        string[] DataMessage = message.Split(new string[1] { " " }, StringSplitOptions.None);
        if (DataMessage.Length > 0)
        {
            string Command = DataMessage[0];
            if (Command == "connect")
            {
                if (DataMessage.Length != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Использование: connect [login] [password]\nПример: connect User1 Password");
                    BCommand = false;
                }
                else BCommand = true;
            }
            else if (Command == "cd") BCommand = true;
            else if (Command == "get")
            {
                if (DataMessage.Length == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Использование: get [NameFile]\nПример: get Test.txt");
                    BCommand = false;
                }
                else BCommand = true;
            }
            else if (Command == "set")
            {
                if (DataMessage.Length == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Использование: set [NameFile]\nПример: set Test.txt");
                    BCommand = false;
                }
                else BCommand = true;
            }
        }
        return BCommand;
    }
}

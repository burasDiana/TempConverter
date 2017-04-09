using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.ReadLine();
                TcpClient clientSocket = new TcpClient("10.200.125.16", 9999);

                Stream ns = clientSocket.GetStream();  
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true; // 

                for (int i = 0; i < 10; i++)
                {
                //  Console.WriteLine("Please write any message to connect...");
                Console.WriteLine("Please write F/C followed by the temperature");
                string message = Console.ReadLine();
                sw.WriteLine(message);
                    string serverAnswer = sr.ReadLine();
                    Console.WriteLine("Server: " + serverAnswer);
                    
                }


                ns.Close();

                clientSocket.Close();

        }
    }
}

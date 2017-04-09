using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TCPServer.ServiceReference1;

namespace TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of the client

            Service1Client client = new Service1Client();

            TcpListener serverSocket = new TcpListener(IPAddress.Any, 9999);
            serverSocket.Start();

            while (true)
            {
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("Server activated");

                Stream ns = connectionSocket.GetStream();

                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true;

                string message = sr.ReadLine();
                string answer = "";
                Console.WriteLine("Client: " + message);

                while (message != null && message != "" )
                {

                    //Console.WriteLine("Client: " + message);

                    int tempC;
                    int tempF;

                    TextReader tr = new StringReader(message);
                    var str1 = tr.ReadLine();

                    if (str1.StartsWith("F"))
                    {
                        tempC = Convert.ToInt32(str1.Split(' ')[1]);
                        answer = client.GetCelsius(tempC).ToString();
                        sw.WriteLine("The temperature in C is: " + answer);
                       

                    }
                   else if (str1.StartsWith("C"))
                    {
                        tempF= Convert.ToInt32(str1.Split(' ')[1]);
                        answer = client.GetCelsius(tempF).ToString();
                        sw.WriteLine("  The temperature in F is: "+ answer);
                      
                    }
                  
                }

                ns.Close();
                connectionSocket.Close();
            }

        }
    }
}

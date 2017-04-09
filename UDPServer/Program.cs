using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UDPServer.ServiceReference1;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //accessing the web service

            Service1Client client = new Service1Client();

            //udp create

            UdpClient udpServer = new UdpClient(9999);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(ip, 9999);

            try
            {
                // Blocks until a message is received on this socket from a remote host (a client).
                Console.WriteLine("Server is blocked");
                while (true)
                {
                    Byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                 
                    //Server activated

                    string receivedData = Encoding.ASCII.GetString(receiveBytes);
                    string[] data = receivedData.Split(' ');
                    string clientName = data[0];
                    
                    string temp = data[1];
                    int value = Convert.ToInt32(data[2]);
                    

                    Console.WriteLine(receivedData);

                    if (temp == "F")
                    {
                        var result = client.GetCelsius(value);
                        string sendData = "Server: " + result;
                        Byte[] sendBytes = Encoding.ASCII.GetBytes(sendData);
                        udpServer.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);
                    }
                    else if (temp == "C")
                    {
                        var result = client.GetFarenheit(value);
                        string sendData = "Server: " + result;
                        Byte[] sendBytes = Encoding.ASCII.GetBytes(sendData);
                        udpServer.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);


                    }


                    Console.WriteLine("This message was sent from " +
                                                RemoteIpEndPoint.Address.ToString() +
                                                " on their port number " +
                                                RemoteIpEndPoint.Port.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}


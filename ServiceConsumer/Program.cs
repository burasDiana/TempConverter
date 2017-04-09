using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceConsumer.ServiceReference1;

namespace ServiceConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of the client

            Service1Client client= new Service1Client();

            //input and output for celsius

            Console.WriteLine("Please write value in F");
            int tempF=Int32.Parse(Console.ReadLine());
            double celcius= client.GetCelsius(tempF);
            Console.WriteLine("The temperature in Celsius is:"+ celcius );


            //input and output for Farenheit

            Console.WriteLine("Please write value in C"); 
            int tempC= Int32.Parse(Console.ReadLine());
            double farenheit = client.GetFarenheit(tempC);
            Console.WriteLine("The temperature in Celsius is:" + farenheit);

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
    }
}

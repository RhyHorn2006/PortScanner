using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Port_scanner
{
    public class Input
    {
        private static Regex portFormat = new Regex(@"\b\d{1,5}\b");

        public static string GetIp()
        {
            Regex ipFormat = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
            Console.WriteLine("Enter an IPv4 address");
            string ip = Console.ReadLine();

            IPAddress ipAddress;

            while (!ipFormat.IsMatch(ip) || !IPAddress.TryParse(ip, out ipAddress))
            {
                Console.WriteLine("Invalid IPv4 address, try again");
                ip = Console.ReadLine();
            }

            return ip;
        }
        
        public static string GetStartingPort()
        {
            Console.WriteLine("Enter starting port");
            string startingPort = Console.ReadLine();

            if (!portFormat.IsMatch(startingPort))
            {
                Console.WriteLine("Invalid port, try again");
                startingPort = Console.ReadLine();
            }
            
            return startingPort;
        }

        public static string GetEndingPort()
        {
            Console.WriteLine("Enter ending port");
            string endingPort = Console.ReadLine();

            if (!portFormat.IsMatch(endingPort))
            {
                Console.WriteLine("Invalid port, try again");
                endingPort = Console.ReadLine();
            }

            return endingPort;
        }
    }
}

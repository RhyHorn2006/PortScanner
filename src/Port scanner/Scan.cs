using System.Text;

namespace Port_scanner
{
    internal class Scan
    {
        public static string Start(string ipAddress, int startingPort, int endingPort)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int port = startingPort; port <= endingPort; port++)
            {
                try
                {
                    var client = new System.Net.Sockets.TcpClient();
                    client.Connect(ipAddress, port);
                    stringBuilder.Append($"Port {port} is open");
                }
                catch (Exception e)
                {
                    stringBuilder.Append($"Port {port} is closed");
                    Console.WriteLine($"Error: {e}");
                }
            }
            return stringBuilder.ToString();
        }
    }
}

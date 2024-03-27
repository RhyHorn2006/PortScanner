namespace Port_scanner
{
    class Program
    {
        static void Main()
        {
            var ipAddress = Input.GetIp();
            var startingPort = Input.GetStartingPort();
            var endingPort = Input.GetEndingPort();
            Scan.Start(ipAddress, int.Parse(startingPort), int.Parse(endingPort));
        }
    }
}


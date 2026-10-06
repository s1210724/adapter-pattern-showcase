using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase.Printers
{
    public class NetworkPrinter
    {
        public void SendToPrinter(string text)
        {
            Console.WriteLine($"Network printer: {text}");
        }
    }
}

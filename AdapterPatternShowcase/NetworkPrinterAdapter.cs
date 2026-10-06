using AdapterPatternShowcase.Printers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase
{
    public class NetworkPrinterAdapter : IPrinter
    {
        private readonly NetworkPrinter _printer;

        public NetworkPrinterAdapter(NetworkPrinter printer)
        {
            _printer = printer;
        }

        public void Print(string text)
        {
            _printer.SendToPrinter(text);
        }
    }
}

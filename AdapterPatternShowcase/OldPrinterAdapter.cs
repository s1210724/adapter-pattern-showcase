using AdapterPatternShowcase.Printers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase
{
    public class OldPrinterAdapter : IPrinter
    {
        private readonly OldPrinter _printer;

        public OldPrinterAdapter(OldPrinter printer)
        {
            _printer = printer;
        }

        public void Print(string text)
        {
            _printer.PrintDocument(text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase
{
    public class PrinterAdapter : IPrinter
    {
        private readonly OldPrinter _printer;

        public PrinterAdapter(OldPrinter printer)
        {
            _printer = printer;
        }

        public void Print(string text)
        {
            _printer.PrintDocument(text);
        }
    }
}
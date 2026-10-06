using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase.Printers
{
    public class OldPrinter
    {
        public void PrintDocument(string text)
        {
            Console.WriteLine($"Old printer: {text}");
        }
    }
}

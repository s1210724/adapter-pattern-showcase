using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase
{
    public class OldPrinter
    {
        public void PrintDocument(string text)
        {
            Console.WriteLine($"Printer: {text}");
        }
    }
}

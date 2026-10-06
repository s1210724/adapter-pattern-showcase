using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase.Printers
{
    public class PdfPrinter
    {
        public void CreatePdf(string text)
        {
            Console.WriteLine($"PDF printer: {text}");
        }
    }
}

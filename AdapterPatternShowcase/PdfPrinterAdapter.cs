using AdapterPatternShowcase.Printers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternShowcase
{
    public class PdfPrinterAdapter : IPrinter
    {
        private readonly PdfPrinter _printer;

        public PdfPrinterAdapter(PdfPrinter printer)
        {
            _printer = printer;
        }

        public void Print(string text)
        {
            _printer.CreatePdf(text);
        }
    }
}

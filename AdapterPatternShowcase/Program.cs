using AdapterPatternShowcase;
using AdapterPatternShowcase.Printers;

IPrinter oldPrinter = new PrinterAdapter(new OldPrinter());
IPrinter networkPrinter = new NetworkPrinterAdapter(new NetworkPrinter());
IPrinter pdfPrinter = new PdfPrinterAdapter(new PdfPrinter());

IPrinter[] printers = { oldPrinter, networkPrinter, pdfPrinter };

foreach (var printer in printers)
{
    printer.Print("Hallo wereld!");
}

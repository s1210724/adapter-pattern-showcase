using AdapterPatternShowcase.Printers;

var oldPrinter = new OldPrinter();
var networkPrinter = new NetworkPrinter();
var pdfPrinter = new PdfPrinter();

oldPrinter.PrintDocument("Factuur");
networkPrinter.SendToPrinter("Rapport");
pdfPrinter.CreatePdf("Brief");
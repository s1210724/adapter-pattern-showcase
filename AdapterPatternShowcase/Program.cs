using AdapterPatternShowcase;

IPrinter printer = new PrinterAdapter(new OldPrinter());

printer.Print("Hallo wereld!");
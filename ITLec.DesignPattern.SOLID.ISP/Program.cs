using System;

namespace ITLec.DesignPattern.SOLID.ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var colorPrinter = new ColorPrinter();
            var scanner = new Scanner();

            var multiJobPrinter = new MultiJobPrinter(printer, scanner);
            multiJobPrinter.Print();

            var multiJobPrinterColor = new MultiJobPrinter(colorPrinter, scanner);
            multiJobPrinterColor.Print();

            Console.Read();
        }
    }
}

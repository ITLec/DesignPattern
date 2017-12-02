using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.ISP
{
 public   class MultiJobPrinter: IPrinter, IScanner
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiJobPrinter(IPrinter printer, IScanner scanner)
        {
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print()
        {
            this.printer.Print();
        }

        public void Scan()
        {
            this.scanner.Scan();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.ISP
{
    public class ColorPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("I am color printer");
        }
    }
}

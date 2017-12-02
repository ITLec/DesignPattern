using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.ISP
{
    public class Scanner : IScanner
    {
        public void Scan()
        {
            Console.WriteLine("I am scanner");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.DIP
{
    public class FileLogger : ILogger
    {
        public void Log(string str)
        {
            Console.WriteLine($"FileLogger: {str}");
        }
    }
}

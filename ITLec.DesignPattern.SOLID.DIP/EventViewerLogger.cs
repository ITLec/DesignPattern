using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.DIP
{
  public  class EventViewerLogger: ILogger
    {

        public void Log(string str)
        {
            Console.WriteLine($"EventViewerLogger: {str}");
        }
    }
}

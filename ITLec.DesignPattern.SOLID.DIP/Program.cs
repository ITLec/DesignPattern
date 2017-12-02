using System;

namespace ITLec.DesignPattern.SOLID.DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLogger = new FileLogger();
            var eventViewerLogger = new EventViewerLogger();

            var worker1 = new Worker(fileLogger);
            worker1.DoWork("Test file Logger");
            Console.WriteLine("=================");
            var worker2 = new Worker(eventViewerLogger);
            worker2.DoWork("Test eventViewerLoggerr");

            Console.Read();

        }
    }
}

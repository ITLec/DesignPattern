using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.DIP
{
public     class Worker
    {
        private ILogger logger;
        public Worker(ILogger logger)
        {
            this.logger = logger;
        }
        public void DoWork(string work)
        {
            Console.WriteLine(work);

            logger.Log(work);
        }
    }
}

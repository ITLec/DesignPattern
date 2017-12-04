using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.Creational.Builder
{
   public  class Worker: Person
    {
        public Worker()
        {

        }
        public string Position;
        public Certification Certification { get; set; }

    }
}

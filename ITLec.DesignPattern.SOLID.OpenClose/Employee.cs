using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
   public class Employee: Person
    {
        public Position Position { get; set; }

        public Person Manager { get; set; }
    }
}

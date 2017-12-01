using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    public class Person
    {
        public string FullName { get; set; }

        public Gender Gender { get; set; }

        public Country Nationality { get; set; }
        public Title Title { get; set; }

        public DateTime Birthday { get; set; }
    }
}

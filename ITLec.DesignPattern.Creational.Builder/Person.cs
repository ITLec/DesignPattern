using System;
using System.Collections.Generic;
using System.Text;
using static ITLec.DesignPattern.Creational.Builder.Enums;

namespace ITLec.DesignPattern.Creational.Builder
{
   public class Person
    {
        public Person()
        {

        }

        public string FullName;
        public Gender Gender { get; set; }
        public Country Nationality { get; set; }
        public Address Address { get; set; }

        public DateTime Birthdate { get; set; }

    }
}

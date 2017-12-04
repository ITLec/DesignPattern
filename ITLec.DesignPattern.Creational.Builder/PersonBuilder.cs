using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.Creational.Builder
{
  public   class PersonBuilder
    {
        public Person person = new Person();

        public AddressBuilder Lives => new AddressBuilder(person);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.Creational.Builder
{
  public   class AddressBuilder: WorkerBuilder
    {
        public AddressBuilder(Worker worker)
        {
            if(worker.Address ==null)
            {
                worker.Address = new Address();
            }
            this.worker = worker;
        }

        public AddressBuilder In(string streetName)
        {
            worker.Address.StreetName = streetName;

            return this;
        }

        public AddressBuilder At(string cityName)
        {
            worker.Address.City = cityName;

            return this;
        }

        public AddressBuilder WithPostalCode(string postalCode)
        {
            worker.Address.PostalCode = postalCode;

            return this;
        }
    }
}

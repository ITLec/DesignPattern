using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.Creational.Builder
{
   public class WorkerBuilder
    {

     protected   Worker worker = new Worker();

               public AddressBuilder Lives => new AddressBuilder(worker);
        public CertificationBuilder Certifies => new CertificationBuilder(worker);
        public BasicInfoBuilder BasicInfo => new BasicInfoBuilder(worker);

        public static implicit operator Worker(WorkerBuilder pb)
        {
            return pb.worker;
        }

        public static implicit operator Person(WorkerBuilder pb)
        {
            return pb.worker;
        }

    }
}

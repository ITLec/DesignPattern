using System;

namespace ITLec.DesignPattern.Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  var pb = new PersonBuilder();

            Person person =(Person) pb.Lives.In("ITLec Streeet")
                                .At("ITLec City").WithPostalCode("4343");
            
            
           Console.WriteLine(person.Address.City);
            */

            var wb = new WorkerBuilder();
            Worker wrkr = wb.BasicInfo.Birthdate(new DateTime(1987,6,12))
                                      .FullName("Rasheed Gomaa")
                                      .Gender(Enums.Gender.Male)
                                      .Nationality(Enums.Country.Egypt)
                             .Lives.In("ITLec Streeet")
                                      .At("ITLec City").WithPostalCode("4343")
                             .Certifies.Name("MCT")
                                      .Authority("Microsoft")
                                      .LicenceNumber("ITLec");

           Console.WriteLine($@"
Full Name: {wrkr.FullName}
City Name: {wrkr.Address.City}
Certification Name: {wrkr.Certification.CertificationName}
                                ");
            
            Console.Read();
        }
    }
}

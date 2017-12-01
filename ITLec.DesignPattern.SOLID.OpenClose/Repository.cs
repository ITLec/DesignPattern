using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
   public class Repository
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            var rasheed = new Employee() { FullName = "Rasheed", Birthday = new DateTime(1987, 6, 12), Gender = Gender.Male, Manager = null, Nationality = Country.Egypt, Position = Position.CEO };
            employees.Add(rasheed);

            var mohamed = new Employee() { FullName = "Mohamed", Birthday = new DateTime(1977, 10, 10), Gender = Gender.Male, Manager = rasheed, Nationality = Country.KSA, Position = Position.CEO };
            employees.Add(mohamed);


            var gehad = new Employee() { FullName = "Gehhad", Birthday = new DateTime(2010, 5, 5), Gender = Gender.Female, Manager = mohamed, Nationality = Country.USA, Position = Position.CFO };
            employees.Add(gehad);



            return employees;
        }
    }
}

using System;

namespace ITLec.DesignPattern.SOLID.OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            var ef = new EmployeeFilter();
            var genderCriteria = new GenderCriteria(Gender.Male);
            var birthdayCriteria = new BirthdayCriteria(new DateTime(1910, 1, 1));
            var genderAndBirthdayCriteria = new AndCriteria<Employee>(genderCriteria, birthdayCriteria);

            var nameCriteria = new NameCriteria("r");

            var nameAndGenderAndBirthdayCriteria = new AndCriteria<Employee>(genderAndBirthdayCriteria, nameCriteria);

            Console.WriteLine("Filter By Gender");
            foreach (var emp in ef.Filter( Repository.GetEmployees(), genderCriteria))
            {
                Console.WriteLine($"Name: {emp.FullName}");
            }
            Console.WriteLine("===================================");


            Console.WriteLine("Filter By Birthday");
            foreach (var emp in ef.Filter(Repository.GetEmployees(), birthdayCriteria))
            {
                Console.WriteLine($"Name: {emp.FullName}");
            }
            Console.WriteLine("===================================");


            Console.WriteLine("Filter By Name");
            foreach (var emp in ef.Filter(Repository.GetEmployees(), nameCriteria))
            {
                Console.WriteLine($"Name: {emp.FullName}");
            }
            Console.WriteLine("===================================");


            Console.WriteLine("Filter By genderAndBirthdayCriteria");
            foreach (var emp in ef.Filter(Repository.GetEmployees(), genderAndBirthdayCriteria))
            {
                Console.WriteLine($"Name: {emp.FullName}");
            }
            Console.WriteLine("===================================");


            Console.WriteLine("Filter By nameAndGenderAndBirthdayCriteria");
            foreach (var emp in ef.Filter(Repository.GetEmployees(), nameAndGenderAndBirthdayCriteria))
            {
                Console.WriteLine($"Name: {emp.FullName}");
            }
            Console.ReadLine();
        }
    }
}

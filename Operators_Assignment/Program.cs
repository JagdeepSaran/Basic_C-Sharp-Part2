using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating first employee
            Employee emp1 = new Employee()
            {
                Id = 101,
                FirstName = "John",
                LastName = "Smith"
            };

            // Creating second employee
            Employee emp2 = new Employee()
            {
                Id = 101, // same ID, so they should be equal
                FirstName = "Michael",
                LastName = "Brown"
            };

            // Compare using overloaded operators
            bool resultEqual = emp1 == emp2;
            bool resultNotEqual = emp1 != emp2;

            Console.WriteLine("Are both employees equal? " + resultEqual);
            Console.WriteLine("Are both employees different? " + resultNotEqual);

            Console.ReadLine();
        }
    }
}
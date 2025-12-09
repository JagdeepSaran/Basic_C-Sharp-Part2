using System;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an Employee object and initializing values
            Employee emp = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 500
            };

            // Calling the overridden method
            emp.SayName();

            Console.ReadLine();
        }
    }
}
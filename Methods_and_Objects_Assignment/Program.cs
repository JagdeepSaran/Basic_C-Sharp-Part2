using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize Employee object
            Employee sam = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1001
            };

            // Call inherited SayName() method
            sam.SayName();

            Console.ReadLine();
        }
    }
}
using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using polymorphism (interface reference)
            IQuitable staffMember = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 999
            };

            // Calling interface method using interface reference
            staffMember.Quit();

            Console.ReadLine();
        }
    }
}
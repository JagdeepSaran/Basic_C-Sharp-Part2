using System;

namespace MethodsAndObjectsAssignment
{
    // Create a class called Person
    public class Person
    {
        // Two string properties as instructed
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method that prints full name
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
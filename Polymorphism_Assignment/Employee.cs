using System;

namespace PolymorphismAssignment
{
    // Employee inherits Person and implements IQuitable
    public class Employee : Person, IQuitable
    {
        public int Id { get; set; }

        // Implement Quit() from the interface
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} with ID {Id} has resigned.");
        }

        // Same SayName override from previous assignment
        public override void SayName()
        {
            Console.WriteLine($"Employee Record: {FirstName} {LastName}, ID: {Id}");
        }
    }
}
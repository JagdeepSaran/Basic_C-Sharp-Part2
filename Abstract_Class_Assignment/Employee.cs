using System;

namespace AbstractClassesAssignment
{
    // Employee inherits from Person
    public class Employee : Person
    {
        // The Employee will also have an Id number
        public int Id { get; set; }

        // Implementing the abstract method from Person class
        public override void SayName()
        {
            Console.WriteLine($"Employee Record -> Name: {FirstName} {LastName}, ID: {Id}");
        }
    }
}
using System;

namespace AbstractClassesAssignment
{
    // Abstract class Person – cannot be instantiated on its own
    public abstract class Person
    {
        // Two properties to store first and last name of a person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method that will be implemented later in a child class
        public abstract void SayName();
    }
}
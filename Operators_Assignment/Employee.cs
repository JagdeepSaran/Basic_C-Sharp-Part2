using System;

namespace OperatorsAssignment
{
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Compare Id values
            return emp1.Id == emp2.Id;
        }

        // Overload != operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }

        // Avoid warnings by overriding these methods
        public override bool Equals(object obj)
        {
            Employee temp = obj as Employee;
            return this.Id == temp.Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
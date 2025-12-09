using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CLASS METHOD ASSIGNMENT ===\n");

            // Ask user for input
            Console.Write("Enter a whole number: ");
            int userValue = Convert.ToInt32(Console.ReadLine());

            // Call first method – integer version
            MyMathClass.DivideNumber(userValue);

            // Call overloaded decimal method
            MyMathClass.DivideNumber((decimal)userValue);

            // Output parameter part
            int tripleValue;

            // Call method with output parameter
            MyMathClass.TripleValue(userValue, out tripleValue);

            // Display output parameter result
            Console.WriteLine($"Your number multiplied by 3 = {tripleValue}");

            Console.WriteLine("\nPress ENTER to exit.");
            Console.ReadLine();
        }
    }
}
using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== METHOD CLASS ASSIGNMENT ===");

            // Ask user for first number
            Console.Write("\nEnter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            // Ask user for second number
            Console.Write("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            // Instantiate the class
            MathOperation operation = new MathOperation();

            // Call the void method by name, passing two numbers
            operation.DoMath(firstNum, secondNum);

            Console.WriteLine("\nMethod execution complete. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
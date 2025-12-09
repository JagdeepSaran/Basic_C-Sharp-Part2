using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculation class
            Calculation calc = new Calculation();

            Console.WriteLine(" === METHOD ASSIGNMENT === ");
            Console.WriteLine();

            // Ask user for first number
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask user for second number (optional)
            Console.Write("Enter a second number (Press ENTER to skip): ");
            string inputSecond = Console.ReadLine();

            int finalResult;

            // If user typed something for the second number
            if (!string.IsNullOrEmpty(inputSecond))
            {
                int num2 = Convert.ToInt32(inputSecond);

                // Call method using both inputs
                finalResult = calc.MultiplyNumbers(num1, num2);
                Console.WriteLine($"\nYou entered two numbers. Result is: {finalResult}");
            }
            else
            {
                // Call method using only first input
                finalResult = calc.MultiplyNumbers(num1);
                Console.WriteLine($"\nYou entered only first number. Result using default second number is: {finalResult}");
            }

            Console.WriteLine("\nPress ENTER to exit...");
            Console.ReadLine();
        }
    }
}
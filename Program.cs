using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number to use in the math operations
            Console.WriteLine("Welcome to the Calling Methods Assignment!");
            Console.Write("Please enter a whole number: ");

            // Read the user input and convert it to an int
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the first method, passing in the user’s number
            int plusFive = NumberMath.AddFive(userNumber);
            // Display the result of the first method
            Console.WriteLine(userNumber + " + 5 = " + plusFive);

            // Call the second method, passing in the same user number
            int doubled = NumberMath.DoubleNumber(userNumber);
            // Display the result of the second method
            Console.WriteLine(userNumber + " * 2 = " + doubled);

            // Call the third method, again using the user number
            int squaredMinusOne = NumberMath.SquareMinusOne(userNumber);
            // Display the result of the third method
            Console.WriteLine(userNumber + "^2 - 1 = " + squaredMinusOne);

            // Final message so the user can see the results before the window closes
            Console.WriteLine("\nAll three methods have finished. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
using System;

namespace MethodClassAssignment
{
    public class MathOperation
    {
        // This method takes two integer parameters
        // first parameter = used for calculation
        // second parameter = displayed only
        public void DoMath(int number1, int number2)
        {
            // Perform a simple math operation
            int result = number1 * 10;

            // Display output
            Console.WriteLine($"First number multiplied by 10 equals: {result}");
            Console.WriteLine($"Your second number was: {number2}");
        }
    }
}

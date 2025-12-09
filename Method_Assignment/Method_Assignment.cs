using System;

namespace MethodAssignment
{
    public class Calculation
    {
        // This method takes two integers - second one optional (default = 5)
        public int MultiplyNumbers(int firstNumber, int secondNumber = 5)
        {
            // Multiply them together
            int result = firstNumber * secondNumber;
            return result;
        }
    }
}

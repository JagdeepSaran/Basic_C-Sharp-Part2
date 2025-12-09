using System;

namespace MainMethodAssignment
{
    public class MyMathMethods
    {
        // Method 1: Takes an int and adds 10 to it
        public int AddTen(int number)
        {
            int result = number + 10; // add 10
            return result; // return integer result
        }

        // Method 2: Takes a decimal and multiplies by 1.5
        public decimal MultiplyValue(decimal number)
        {
            decimal result = number * 1.5m; // multiply by 1.5
            return result; // return decimal result
        }

        // Method 3: Takes a string, tries converting to int, subtracts 2
        public int ConvertAndSubtract(string value)
        {
            // Convert string to integer
            int convertedNumber = Convert.ToInt32(value);

            int result = convertedNumber - 2; // subtract 2
            return result; // return integer
        }
    }
}
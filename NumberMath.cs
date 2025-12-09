using System;

namespace CallingMethodsAssignment
{
    // This class holds the math methods we will call from Main
    public class NumberMath
    {
        // Method 1 – adds 5 to the incoming number and returns the result
        public static int AddFive(int value)
        {
            int result = value + 5; // do the math operation
            return result; // send the result back to the caller
        }

        // Method 2 – multiplies the incoming number by 2 and returns the result
        public static int DoubleNumber(int value)
        {
            int result = value * 2; // do the math operation
            return result; // send the result back to the caller
        }

        // Method 3 – squares the incoming number and then subtracts 1
        public static int SquareMinusOne(int value)
        {
            int result = (value * value) - 1; // do the math operation
            return result; // send the result back to the caller
        }
    }
}
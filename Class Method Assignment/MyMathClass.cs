using System;

namespace ClassMethodAssignment
{
    // Declaring class as static
    public static class MyMathClass
    {
        // Method #1: takes integer and prints value divided by 2
        public static void DivideNumber(int number)
        {
            int result = number / 2; // Divide by 2
            Console.WriteLine($"Your number divided by 2 = {result}");
        }

        // Method #2 (OVERLOADED): takes decimal instead of int
        public static void DivideNumber(decimal number)
        {
            decimal result = number / 2; // Divide by 2
            Console.WriteLine($"Your decimal value divided by 2 = {result}");
        }

        // Method #3: uses OUTPUT parameter
        public static void TripleValue(int number, out int answer)
        {
            answer = number * 3; // send back value
        }
    }
}

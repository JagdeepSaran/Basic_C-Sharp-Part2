using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating a list of integers that will be used
        List<int> numberList = new List<int>() { 10, 22, 34, 50, 75, 100, 150, 300 };

        bool validNumber = false; // Flag for correct input
        float divideValue = 0; // Variable to store value to divide by

        // Keep asking for input until it is valid
        while (validNumber == false)
        {
            try
            {
                Console.WriteLine("Enter a number to divide all list values by:");

                // Convert user input
                divideValue = float.Parse(Console.ReadLine());

                // Check if user entered zero
                if (divideValue == 0)
                {
                    Console.WriteLine("Cannot divide by ZERO! Enter a value other than 0.\n");
                }
                else
                {
                    // Valid division value
                    validNumber = true;

                    // Loop through each number and divide
                    foreach (int num in numberList)
                    {
                        float answer = num / divideValue;
                        Console.WriteLine(num + " divided by " + divideValue + " = " + answer);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid input! Please enter a NUMERIC value.\n");
            }
        }

        // Final message outside try/catch
        Console.WriteLine("\nProgram finished executing the try/catch logic.");
    }
}
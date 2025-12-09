using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a string array 
            string[] carBrands = { "BMW", "Mercedes", "Audi", "Honda", "Toyota", "Ford", "Tesla", "Kia", "Hyundai", "Volvo" };

            // Ask user to select index from 0–9
            Console.WriteLine("Select an index number between 0 and 9 to display a car brand:");
            bool validBrand = false;
            int brandIndex = 0;

            // Validation loop for string array selection
            while (!validBrand)
            {
                try
                {
                    brandIndex = Convert.ToInt32(Console.ReadLine());

                    // If index is valid
                    Console.WriteLine($"Your selected car brand is: {carBrands[brandIndex]}");
                    validBrand = true;
                }
                catch
                {
                    // When invalid index or input
                    Console.WriteLine("Invalid selection. Please pick a number between 0 and 9:");
                }
            }


            // 2. Create an integer array
            int[] ratings = { 5, 8, 9, 4, 7, 10, 6, 3, 9, 8 };

            Console.WriteLine("\nSelect an index number between 0 and 9 to see its rating:");
            bool validRating = false;
            int ratingIndex = 0;

            // Validation loop for integer array selection
            while (!validRating)
            {
                try
                {
                    ratingIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The rating is: {ratings[ratingIndex]}");
                    validRating = true;
                }
                catch
                {
                    Console.WriteLine("Invalid selection. Please pick a number between 0 and 9:");
                }
            }


            // 3. Create a list of strings
            List<string> occupations = new List<string>()
            {
                "Mechanic", "Truck Driver", "Electrician", "Software Developer",
                "Nurse", "Accountant", "UX Designer", "Teacher", "Chef", "Pilot"
            };

            Console.WriteLine("\nSelect an index number between 0 and 9 to display an occupation:");
            bool validList = false;
            int listIndex = 0;

            // Validation loop for list selection
            while (!validList)
            {
                try
                {
                    listIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your selected occupation is: {occupations[listIndex]}");
                    validList = true;
                }
                catch
                {
                    Console.WriteLine("Invalid selection. Please pick a number between 0 and 9:");
                }
            }

            Console.WriteLine("\nProgram finished. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
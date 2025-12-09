using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 – Create one-dimensional array of strings
            string[] messages = { "Hello", "Welcome", "Good job", "Nice work", "Keep going" };

            // Ask user to input some text
            Console.WriteLine("Enter some text to add to each message:");
            string userInput = Console.ReadLine();

            // Loop #1 – iterate through each string in the array and append user input
            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] = messages[i] + " " + userInput;
            }

            // Loop #2 – print each string in the updated array one at a time
            Console.WriteLine("\nUpdated messages:");
            foreach (string msg in messages)
            {
                Console.WriteLine(msg);
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();

            // ---------------------- PART 2 START ----------------------

            // Step 1: Create an infinite loop
            // This loop becomes infinite because the condition always remains true
            bool keepRunning = true;

            // Saving point mentioned in instructions (no actual change in code needed)

            // Step 3: We will FIX it so that it stops properly
            // We will stop the loop when user types the word "stop"

            Console.WriteLine("\nType 'stop' to exit the loop.");

            while (keepRunning)
            {
                Console.WriteLine("You are inside an infinite loop... Type 'stop' to escape:");
                string userCommand = Console.ReadLine();

                // Step 3: Fix - user enters stop -> loop ends
                if (userCommand.ToLower() == "stop")
                {
                    keepRunning = false;
                }
            }

            // Step 4: Comment explaining how loop was fixed
            // FIX EXPLANATION:
            // The loop was infinite because keepRunning was always true.
            // We fixed it by changing keepRunning to false when user typed "stop",
            // causing the loop condition to become false and end the loop.

            // ---------------------- PART 2 END ----------------------
            // ---------------------- PART 3 START ----------------------

            Console.WriteLine("\n--- Part 3 Output ---");

            // Step 1: Loop using the < operator
            Console.WriteLine("\nLoop using < operator:");
            for (int i = 0; i < 5; i++) // This loop runs 0 to 4
            {
                Console.WriteLine("Value of i is: " + i);
            }

            // Step 3: Loop using the <= operator
            Console.WriteLine("\nLoop using <= operator:");
            for (int j = 0; j <= 5; j++) // This loop runs 0 to 5
            {
                Console.WriteLine("Value of j is: " + j);
            }

            // Explanation:
            // First loop (<) executes 5 times: 0, 1, 2, 3, 4
            // Second loop (<=) executes 6 times: 0, 1, 2, 3, 4, 5

            // ---------------------- PART 3 END ----------------------

            // ---------------------- PART 4 START ----------------------

            Console.WriteLine("\n--- Part 4 Output ---");

            // Step 1: Unique list of strings
            List<string> cities = new List<string>()
{
    "Toronto",
    "Vancouver",
    "Calgary",
    "Montreal",
    "Ottawa",
    "Edmonton"
};

            // Step 2: Ask user to input text to search
            Console.WriteLine("\nEnter a city name to search in the list:");
            string searchText = Console.ReadLine();

            // Step 3 & 5: Loop through list showing index and stop once match found
            bool found = false;

            for (int i = 0; i < cities.Count; i++)
            {
                // Check if string matches ignoring case
                if (cities[i].ToLower() == searchText.ToLower())
                {
                    Console.WriteLine($"Match found! \"{cities[i]}\" is at index: {i}");
                    found = true;
                    break; // stops loop after first match as required
                }
            }

            // Step 4: If user entry not found
            if (!found)
            {
                Console.WriteLine($"Sorry, \"{searchText}\" is not in the list.");
            }

            // ---------------------- PART 4 END ----------------------

            // ---------------------- PART 5 START ----------------------

            Console.WriteLine("\n--- Part 5 Output ---");

            // Step 1: List with at least two identical strings
            List<string> carModels = new List<string>()
{
    "Honda Civic",
    "Toyota Camry",
    "Honda Civic", // duplicate
    "Ford Mustang",
    "Toyota Camry", // duplicate
    "BMW X5"
};

            // Step 2: Ask user what they want to search for
            Console.WriteLine("\nEnter a car model to search in the list:");
            string modelSearch = Console.ReadLine();

            // Step 3: Loop through list and display ALL matching indexes
            bool matchFound = false;

            for (int i = 0; i < carModels.Count; i++)
            {
                if (carModels[i].ToLower() == modelSearch.ToLower())
                {
                    Console.WriteLine($"Match found: \"{carModels[i]}\" at index {i}");
                    matchFound = true;
                    // no break statement allowed!!!
                }
            }

            // If nothing matched, tell the user
            if (!matchFound)
            {
                Console.WriteLine($"Sorry, \"{modelSearch}\" does not exist in the list.");
            }

            // ---------------------- PART 5 END ----------------------

            // ---------------------- PART 6 START ----------------------

            Console.WriteLine("\n--- Part 6 Output ---");

            // Step 1: List with duplicates
            List<string> students = new List<string>()
{
    "Aman",
    "Simran",
    "Aman", // duplicate
    "Raj",
    "Manpreet",
    "Simran" // duplicate
};

            // We need a secondary list to check whether item appeared before
            List<string> seenNames = new List<string>();

            // Step 2: foreach loop evaluating items
            foreach (string person in students)
            {
                // Step 2 check: If name was already seen → duplicate
                if (seenNames.Contains(person))
                {
                    // Print message indicating duplicate
                    Console.WriteLine($"{person} - this item is a duplicate");
                }
                else
                {
                    // Add the item into memory for later comparisons
                    seenNames.Add(person);

                    // Print message indicating unique
                    Console.WriteLine($"{person} - this item is unique");
                }
            }

            // Step 4: Comments explaining logic:
            // We store each name in 'seenNames' when encountered for the first time.
            // When a name is seen again, we detect it using Contains() and show 'duplicate'.

            // ---------------------- PART 6 END ----------------------
        }
    }
}
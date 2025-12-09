using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the class
            MyMathMethods methods = new MyMathMethods();

            Console.WriteLine("=== Main Method Assignment ===\n");

            // First Input (int)
            Console.Write("Enter a whole number: ");
            int userInt = Convert.ToInt32(Console.ReadLine());

            int intResult = methods.AddTen(userInt); // calling first method
            Console.WriteLine($"Result after adding 10: {intResult}\n");


            // Second Input (decimal)
            Console.Write("Enter a decimal number (ex. 12.5): ");
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());

            decimal decimalResult = methods.MultiplyValue(userDecimal); // calling second method
            Console.WriteLine($"Result after multiplying by 1.5: {decimalResult}\n");


            // Third Input (string, that equals a number)
            Console.Write("Enter a numeric value as TEXT (e.g. '20'): ");
            string userString = Console.ReadLine();

            int stringResult = methods.ConvertAndSubtract(userString); // calling third method
            Console.WriteLine($"Result after converting and subtracting 2: {stringResult}\n");


            Console.WriteLine("All methods completed successfully!");
            Console.ReadLine();
        }
    }
}
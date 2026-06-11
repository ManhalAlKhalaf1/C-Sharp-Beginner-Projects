using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display the mandatory welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt the user for the package weight
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package is too heavy (greater than 50)
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End the program early
                return; 
            }

            // 3. Prompt the user for the package dimensions
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // 4. Calculate the dimensions total (sum of width, height, and length)
            double dimensionsTotal = width + height + length;

            // Check if the dimensions total is greater than 50
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End the program early
                return;
            }

            // 5. Calculate the shipping quote
            // Formula: (Width * Height * Length * Weight) / 100
            double quote = (width * height * length * weight) / 100.0;

            // 6. Display the final quote to the user formatted as a dollar amount
            // The ":F2" format specifier ensures it prints exactly 2 decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keeps the console window open until a key is pressed (useful when running locally)
            Console.ReadLine();
        }
    }
}

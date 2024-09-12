using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial greeting message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the weight exceeds the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program if the package is too heavy
            }

            // Prompt user for the package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompt user for the package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompt user for the package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if the dimensions exceed the limit
            int dimensionsTotal = width + height + length;
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program if the package is too big
            }

            // Calculate the shipping quote
            int volume = width * height * length;
            decimal quote = (volume * weight) / 100.0m;

            // Display the shipping quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}

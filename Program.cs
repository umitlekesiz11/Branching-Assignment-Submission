using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Launches the application with a customer service greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Gathers and stores the customer's package weight information
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Inspects the package weight to ensure compliance with shipping regulations
            if (weight > 50)
            {
                // Communicates the weight limitation policy to the customer
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Concludes the application when weight exceeds the threshold
            }

            // Records the customer-provided width measurement of the package
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Records the customer-provided height measurement of the package
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Records the customer-provided length measurement of the package
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Evaluates the package's total dimensions against shipping guidelines
            if (width + height + length > 50)
            {
                // Informs the customer about the dimensional restrictions for shipping
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Ends the application when dimensions are excessive
            }

            // Implements the company's pricing algorithm to generate a shipping quote
            float quote = (height * width * length * weight) / 100;

            // Displays the calculated shipping price with appropriate monetary formatting
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Pauses the application until the customer signals readiness to proceed
            Console.ReadKey();
        }
    }
}
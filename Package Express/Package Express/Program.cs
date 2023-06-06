using System;

namespace Package_Express
{
    class Package_Size
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight");
            string num1 = Console.ReadLine();
            int weight = Convert.ToInt32(num1);
            if (weight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width");
            string num2 = Console.ReadLine();
            int width = Convert.ToInt32(num2);

            Console.WriteLine("Please enter the package height");
            string num3 = Console.ReadLine();
            int height = Convert.ToInt32(num3);

            Console.WriteLine("Please enter the package length");
            string num4 = Console.ReadLine();
            int length = Convert.ToInt32(num4);

            if (width + height + length <= 50)
            {
                int total = width * height * length;
                int totalPrice = total * weight / 100;
                Console.WriteLine("Your estimated total for shipping this package is " + totalPrice + " Thank you!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
        }
    }
}

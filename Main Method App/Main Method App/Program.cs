using System;

namespace Main_Method_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();

            Console.WriteLine("Please enter a number to use in the operation.");// writes the quotated text to the console
            int chosenNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you wish, you may enter a second number. If not, leave blank.");//same as above
            string chosenNum2 = Console.ReadLine();

            if (chosenNum2 == "")// if function that calculates the given number and multiplies and divides
            {
                Console.WriteLine("The operation came out to be:");
                Console.WriteLine("(" + chosenNum1 + " * 7) / 2 = " + method.Operation(chosenNum1));
            }
            else // if it doesn't run the top it will run the below
            {
                int chosenNum2Int = Convert.ToInt32(chosenNum2);
                Console.WriteLine("The operation came out to be:");
                Console.WriteLine("(" + chosenNum1 + " * 7) / " + chosenNum2Int + " = " + method.Operation(chosenNum1, chosenNum2Int));
            }

            Console.ReadLine();// ends the function
        }
    }
}

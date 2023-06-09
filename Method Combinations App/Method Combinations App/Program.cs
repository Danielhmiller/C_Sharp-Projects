using System;

namespace Method_Combinations_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();

            Console.WriteLine("Enter an integer.\n");
            int chosenNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + chosenNum1 + " * 15 = " + method.Operate(chosenNum1));

            Console.WriteLine("Enter an decimal.\n");
            decimal chosenNum2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n" + chosenNum2 + " + 25 = " + method.Operate(chosenNum2));

            Console.WriteLine("Enter an number.\n");
            string chosenNum3 = Console.ReadLine();
            Console.WriteLine("\n" + chosenNum3 + " * (7 + 16) = " + method.Operate(chosenNum3));

            Console.ReadLine();
        }
    }
}

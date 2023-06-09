using System;
using System.Collections.Generic;

namespace Try_Catch_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>
            {
                1,
                2,
                7,
                4,
                9,
                8,
                3,
                5,
                6
            };

            try
            {
                Console.WriteLine("Enter a number to divide the list by...");
                int num = Convert.ToInt32(Console.ReadLine());
                foreach (int i in intList)
                {
                    int dividend = i / num;
                    Console.WriteLine(i + " divided by " + num + " equals " + dividend);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program has completed!");
            Console.Read();
        }
    }
}

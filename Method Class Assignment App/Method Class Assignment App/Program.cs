using System;

namespace Method_Class_Assignment_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() method, instantiate that class.
            Method method = new Method();

            // Have the user enter a number.
            Console.WriteLine("Input an integer.\n");
            int chosenInt = Convert.ToInt32(Console.ReadLine());

            // Call the method on that number.
            method.Methodclass(chosenInt);

            // Have the user enter 2 numbers.
            Console.WriteLine("\n  You can also input an integer if you would like to.\n");
            int chosenInt2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n input another integer.\n");
            int chosenInt3 = Convert.ToInt32(Console.ReadLine());

            // Call the method on that number(Overloaded).
            method.Methodclass(chosenInt2, chosenInt3);

            // Call the method on that number(Output).
            method.OutputMethod(out int num2);

            // Call a method from a static class.
            StatClass.Method2();

            Console.Read();
        }
    }
}

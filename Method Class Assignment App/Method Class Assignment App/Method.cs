using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Class_Assignment_App
{
    class Method
    {
        // Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
        public void Methodclass(int num)
        {
            // Entered number, divided by two.
            int result = num / 2;

            // Display the output to the screen.
            Console.WriteLine("\n" + num + " / 2 = " + result);
        }

        // Create a method with output parameters.
        public void OutputMethod(out int num2)
        {
            num2 = 10;
            Console.WriteLine("\n" + num2);
        }

        // Overload a method.
        public void Methodclass(int num3, int num4 = 5)
        {
            int result = (num3 / 2) * num4;
            Console.WriteLine("\n" + num3 + "  " + num4 + " = " + result);
        }
    }

    // Declare a class to be static.
    static class StatClass
    {
        public static void Method2()
        {
            Console.WriteLine("\nThis text comes from a static method.");
        }
    }
}

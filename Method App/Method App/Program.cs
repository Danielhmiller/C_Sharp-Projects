using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number that you want to perform the math operations on below.\n");
            int chosenNum = Convert.ToInt32(Console.ReadLine());// the class is converting to integers

            Class1 method = new Class1();
            //the console write lines are adding, multiplying and dividing whatever integer is typed in plus the values inserted below
            Console.WriteLine("\n" + chosenNum + " + 45 = " + method.Add(chosenNum));
            Console.WriteLine("\n" + chosenNum + " * 7 = " + method.Multiply(chosenNum));
            Console.WriteLine("\n" + chosenNum + " / 3 = " + method.Divide(chosenNum));

            Console.Read();
        }
    }
}

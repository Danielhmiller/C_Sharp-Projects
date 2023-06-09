using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)//voiding the main method and only showing the second number is what the entire block of code is doing. 
        {
            Method method = new Method();//calling the method class from method.cs

            method.Operation(num1: 3, num2: 9);

            Console.ReadLine();
        }
    }
}

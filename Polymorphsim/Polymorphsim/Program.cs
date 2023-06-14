using System;

namespace Polymorphsim
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuitable employee = new Employee();

            employee.Quit("Sample Student"); //call Quit method from interface IQuittable

            Console.ReadLine();
        }
    }
}

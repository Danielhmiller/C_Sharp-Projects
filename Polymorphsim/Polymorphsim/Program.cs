using System;

namespace Polymorphsim
{
    class Program
    {
        static void Main(string[] args)
        {
            Iquittable employee = new Employee();

            employee.Quit("Sample Student"); //call Quit method from interface IQuittable

            Console.ReadLine(); // keep console window open
        }
    }
}

using System;

namespace Objects_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee = new Employees() { FirstName = "Sample ", LastName = "Student" };
            employee.SayName();
            Console.Read();
        }
    }
}

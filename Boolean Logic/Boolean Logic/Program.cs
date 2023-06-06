using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge);

            Console.WriteLine("Have you ever had a DUI?");
            bool noDui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            string yourTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(yourTickets);

            Console.WriteLine("Qualified?");
            bool qualified = (age >= 16 && !noDui && tickets <= 3);

            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}

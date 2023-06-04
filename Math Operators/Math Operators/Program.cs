using System;

namespace Math_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //First person information
            Console.WriteLine("Person 1");
            string yourName = Console.ReadLine();

            Console.WriteLine("Hello " + yourName + " what is your hourly rate?");
            string hourlyRate = Console.ReadLine();
            int perOneHour = Convert.ToInt32(hourlyRate);

            Console.WriteLine("Okay " + yourName + " how many hours did you work this week?");
            string hoursWorked = Console.ReadLine();
            int perOneWorked = Convert.ToInt32(hoursWorked);
            int total = perOneHour * perOneWorked;
            int salaryOne = total * 52;

            //Second person information
            Console.WriteLine("Person 2");
            string yourNameTwo = Console.ReadLine();

            Console.WriteLine("Hello " + yourNameTwo + " what is your hourly rate?");
            string hourlyRateTwo = Console.ReadLine();
            int perTwoHour = Convert.ToInt32(hourlyRateTwo);

            Console.WriteLine("Okay " + yourNameTwo + " how many hours did you work this week?");
            string hoursWorkedTwo = Console.ReadLine();
            int perTwoWorked = Convert.ToInt32(hoursWorkedTwo);
            int totalTwo = perTwoHour * perTwoWorked;
            int salaryTwo = totalTwo * 52;

            //Annual Salary information
            Console.WriteLine("Annual Salary for " + yourName + " is " + salaryOne);
            Console.WriteLine("Annual Salary for " + yourNameTwo + " is " + salaryTwo);

            int combined = salaryOne - salaryTwo;

            Console.WriteLine("Does " + yourName + " have more money than " + yourNameTwo);
            bool TotalOne = salaryOne > salaryTwo;
            Console.WriteLine(TotalOne);
            Console.ReadLine();
        }
    }
}

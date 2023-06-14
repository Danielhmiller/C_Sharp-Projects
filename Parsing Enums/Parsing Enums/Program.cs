using System;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day of the week is today?");
                string dayEntered = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayEntered);

                if (day == DaysOfTheWeek.Wednesday)
                {
                    Console.WriteLine("Today is Wednesday.");
                }
                else
                {
                    Console.WriteLine("Today is not " + day);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.Read();
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}

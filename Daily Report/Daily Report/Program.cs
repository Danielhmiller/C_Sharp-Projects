using System;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy!");
            Console.ReadLine();
            //Press enter to go to next part
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on and what page are you on? Press enter after each response");
            string courseName = Console.ReadLine();
            string pageNumber = Console.ReadLine();
            //Next line types out the printed text as well as the two strings above
            Console.WriteLine("So " + yourName + " your on the " + courseName + " course and on page " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer true or false");
            bool trueAnswer = true;
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string numberHours = Console.ReadLine();
            Console.WriteLine("So " + yourName + " you did " + numberHours + " today? ");
            Console.ReadLine();

            Console.WriteLine("Wonderful! Keep up the good work and thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

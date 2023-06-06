using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Console_Number_App
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 - 20");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessed = number == 8;
            //Do while Statement
            do
            {
                switch (number)
                {
                    default:
                        Console.WriteLine("Close! but no cigar!");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("Cold");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 11:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("Hot");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("You did it! Good Job!");
                        guessed = true;
                        break;

                    case 7:
                        Console.WriteLine("Hot");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Warmer");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Cold");
                        Console.WriteLine("Guess a number between 1 - 20");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            while (!guessed);

            Console.Read();

            Console.WriteLine("Guess a number between 1 - 10");
            int num = Convert.ToInt32(Console.ReadLine());
            bool guess = num == 2;

            //while statement
            while (guess == false)
            {
                switch (num)
                {
                    case 3:
                        Console.WriteLine("Nice One! You got it!");
                        guess = true;
                        break;

                    case 2:
                        Console.WriteLine("Not quite right, try again");
                        Console.WriteLine("Guess a number between 1 - 10");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("So Close, try again");
                        Console.WriteLine("Guess a number between 1 - 10");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 1:
                        Console.WriteLine("Nice try but that is not correct");
                        Console.WriteLine("Guess a number between 1 - 10");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Nope, Try again");
                        Console.WriteLine("Guess a number between 1 - 10");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    }

            }
        }   
    }
}

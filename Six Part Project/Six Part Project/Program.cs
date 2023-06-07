using System;

namespace Six_Part_Project
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Select an index of the Array");
                int[] numArray = new int[] { 1, 2, 3, 4, 5 };
                Console.WriteLine("Please input a number.");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input > numArray.Length)
                {
                    Console.WriteLine("Index Does not exist ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(numArray[input]);
                }
                Console.ReadLine();


                Console.WriteLine("Guess a number between 1 - 10");
                int number = Convert.ToInt32(Console.ReadLine());
                bool guess = number == 7;

                //I made my infinite loop into a while statement
                while (guess == false)
                {
                    switch (number)
                    {
                        case 88:
                            Console.WriteLine("You did it!");
                            guess = true;
                            break;

                        case 99:
                            Console.WriteLine("WRONG, try again");
                            Console.WriteLine("Guess a number between 1 - 100");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 57:
                            Console.WriteLine("One more try!");
                            Console.WriteLine("Guess a number between 1 - 100");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 5:
                            Console.WriteLine("Nice try but that is not correct");
                            Console.WriteLine("Guess a number between 1 - 100");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                        default:
                            Console.WriteLine("Nope, Try again");
                            Console.WriteLine("Guess a number between 1 - 100");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
            }
        }
    }   
    

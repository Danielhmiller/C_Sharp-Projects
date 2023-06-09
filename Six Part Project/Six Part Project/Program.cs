using System;
using System.Collections.Generic;

namespace Six_Part_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            string[] strArray = { "Hello", "Goodbye", "See you later", "Nice to meet you", "Good to see you", "How are you" };

            Console.WriteLine("Input some text below.\n");
            string input = Console.ReadLine();

            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strArray[i] + " " + input;
            }

            Console.WriteLine("\n");

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine("\n" + strArray[i]);
            }

            Console.ReadLine();
            // End Part 1

            // Part 2
            int num = 1;

            do
            {
                Console.WriteLine(num++);
            }
            // To make this an infinite loop, change (num < 5000) ---> (num > 0).
            while (num < 5000);

            Console.WriteLine("Ending number is " + num);
            Console.ReadLine();
            // End Part 2

            // Part 3
            int loopNum = 0;
            int loopNum2 = 0;

            while (loopNum < 10)
            {
                loopNum++;
                Console.WriteLine(loopNum);
            }

            Console.ReadLine();

            while (loopNum2 <= 19)
            {
                loopNum2++;
                Console.WriteLine(loopNum2);
            }
            // End Part 3

            // Part 4
            List<string> wordList = new List<string>
            {
                "oblivious",
                "brainless",
                "slow",
                "cool",
                "level",
                "indifferent",
                "fast",
                "class",
                "temper",
                "compare",
                "injure",
                "stick",
                "aspiring",
                "flock",
                "imminent",
                "extra-large",
                "spark",
                "pond",
                "passenger",
                "groan",
                "remember",
                "broom",
                "plan",
                "clumsy",
                "buff"
            };

            Console.WriteLine("\n\nSearch the String List. Enter your search term below.\n");
            string searchTerm = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordList[i] == searchTerm)
                {
                    Console.WriteLine("\n\"" + searchTerm + "\" is at indices " + wordList.IndexOf(searchTerm) + ".");
                    found = true;
                    break;
                }
                if (!found)
                {
                    Console.WriteLine("\n\"" + searchTerm + "\" is not in the list.");
                }
            }
            // End Part 4

            // Part 5
            List<string> wordList2 = new List<string>
            {
                "oblivious",
                "brainless",
                "slow",
                "cool",
                "level",
                "indifferent",
                "fast",
                "class",
                "temper",
                "compare",
                "injure",
                "stick",
                "aspiring",
                "flock",
                "imminent",
                "extra-large",
                "spark",
                "pond",
                "passenger",
                "groan",
                "remember",
                "level",
                "plan",
                "clumsy",
                "buff"
            };

            Console.WriteLine("\n\nSearch the String List. Enter your search term below.\n");
            string searchTerm1 = Console.ReadLine();
            bool found1 = false;

            for (int i = 0; i < wordList2.Count; i++)
            {
                if (wordList2[i] == searchTerm1)
                {
                    Console.WriteLine("\n\"" + searchTerm1 + "\" is at indices " + i + ".");
                    found1 = true;
                }
                if (!found1)
                {
                    Console.WriteLine("\n\"" + searchTerm1 + "\" is not in the list.");
                }
            }
            // End Part 5

            Console.WriteLine("\n");
            Console.ReadLine();

            //Part 6
            List<string> wordList3 = new List<string>
            {
                "oblivious",
                "brainless",
                "slow",
                "cool",
                "level",
                "indifferent",
                "fast",
                "class",
                "temper",
                "compare",
                "injure",
                "stick",
                "aspiring",
                "flock",
                "imminent",
                "extra-large",
                "spark",
                "pond",
                "passenger",
                "groan",
                "remember",
                "act",
                "plan",
                "clumsy",
                "buff"
            };

            List<string> checkList = new List<string>();

            foreach (string s in wordList3)
            {
                if (checkList.Contains(s))
                {
                    Console.WriteLine("\n\"" + s + "\" already appears in the list.");
                }
                else
                {
                    Console.WriteLine("\n\"" + s + "\" hasn't appeared yet.");
                    checkList.Add(s);
                }
            }
            // End part 6

            Console.Read();
        }
    }
}


using System;
using System.Collections.Generic;

namespace Console_App_Arrays
{
    class Arrays
    {
            static void Main()
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



                Console.WriteLine("Select an index of the Array");
                string[] Alphabet = { "a", "b", "c", "d", "e" };
                int input2 = Convert.ToInt32(Console.ReadLine());

                if (input2 > Alphabet.Length)
                {
                    Console.WriteLine("Index Does not exist ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(Alphabet[input2]);
                }


                List<string> intList = new List<string>();
                intList.Add("Blue");
                intList.Add("Yellow");
                intList.Add("Purple");
                intList.Add("Green");
                intList.Add("Red");
                Console.WriteLine("Select an index of the Array");
                int input3 = Convert.ToInt32(Console.ReadLine());

                if (input3 > intList.Count)
                {
                    Console.WriteLine("Index Does not exist ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(intList[input3]);
                }
                Console.ReadLine();
            }
    }
}

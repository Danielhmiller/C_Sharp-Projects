﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateTime.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset date = DateTimeOffset.Now;

            Console.WriteLine(date);

            Console.WriteLine("Please enter a number...");
            int num = Convert.ToInt32(Console.ReadLine());// converts readline into an int

            date = date.AddHours(num);

            Console.WriteLine("The time in " + num + " hours will be " + date);

            Console.Read();
        }
    }
}

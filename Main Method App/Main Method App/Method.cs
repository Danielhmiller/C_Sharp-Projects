using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method_App
{
    class Method
    {
        public int Operation(int num1, int num2 = 2)// class that is being called into the program.cs
        {
            int result = (num1 * 7) / num2;
            return result;
        }
    }
}

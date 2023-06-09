using System;
using System.Collections.Generic;
using System.Text;

namespace Method_App
{
    class Class1// the class below is the formula that is being called into the program.cs to do those calculations
    {
        public int Add(int num1)
        {
            int result1 = num1 + 25;
            return result1;
        }
        public int Multiply(int num2)
        {
            int result2 = num2 * 5;
            return result2;
        }
        public int Divide(int num3)
        {
            int result3 = num3 / 2;
            return result3;
        }
    }
}

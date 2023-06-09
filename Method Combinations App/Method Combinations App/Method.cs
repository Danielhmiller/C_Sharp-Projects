using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Combinations_App
{
    class Method
    {
            public int Operate(int num)
            {
                int result = num * 15;
                return result;
            }
            public int Operate(decimal num)
            {
                int result = Convert.ToInt32(num) + 25;
                return result;
            }
            public int Operate(string num)
            {
                int result = Convert.ToInt32(num) * (7 + 16);
                return result;
            }
        }
}

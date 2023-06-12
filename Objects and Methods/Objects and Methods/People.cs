using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_and_Methods
{
    class People
    {
        public string FirstName;
        public string LastName;

        public void SayName()
        {
            Console.WriteLine("Name: " + "[" + FirstName + LastName + "]");
        }
    }
}

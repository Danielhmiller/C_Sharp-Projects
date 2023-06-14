using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphsim
{
    public abstract class Person
    {

        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }


        public virtual void SayName() // virtual Method "SayName"
        {
            //Nested Foreach loops put first and last names together and concatenate them
            foreach (string firstName in FirstName)
            {

                foreach (string lastName in LastName)
                {
                    Console.WriteLine("\"" + firstName + "\"" + " " + "\"" + lastName + "\"");
                }
            }

        }
    }
}

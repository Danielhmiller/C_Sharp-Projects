using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphsim
{
    class Empolyee : Person, IQuitable //new Class Employee inherts from Person Class and has Interface IQuittable 
    {
        public void Quit(string name)
        {

            Console.WriteLine(name + " Quits.");

        }
    }
}

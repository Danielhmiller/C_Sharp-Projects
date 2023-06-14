using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphsim
{
    class Empolyees : Person, Iquittable //new Class Employee inherts from Person Class and has Interface IQuittable 
    {
        public void Quit(string name)
        {

            Console.WriteLine(name + " Quits.");

        }
    }
}

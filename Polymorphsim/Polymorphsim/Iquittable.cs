using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphsim
{
    class Iquittable
    {
        interface IQuittable
        {
            //void Quit(Employee employee); //void method called Quit
            void Quit(string name);
        }
    }
}

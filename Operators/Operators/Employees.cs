using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    public class Employee
    {
        public int Id { get; set; }
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }



        public static bool operator ==(Employee id1, Employee id2) // overloading operator ==
        {
            return (id1.Id == id2.Id);

        }
        public static bool operator !=(Employee id1, Employee id2) // overloading operator !=
        {
            return (id1.Id != id2.Id);

        }
    }
}

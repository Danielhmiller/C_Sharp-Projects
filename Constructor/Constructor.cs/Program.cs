using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // const variable
            const string name = "Daniel";

            // var variable
            var id = 25;

            // Chain 3 constructors together
            Construct con1 = new Construct(), con2 = new Construct("Jada", 22), con3 = new Construct("Ryan");

            Console.WriteLine(con1.name + " " + con1.id);
            Console.WriteLine(con2.name + " " + con2.id);
            Console.WriteLine(con3.name + " " + con3.id);

            Console.Read();
        }
    }
}

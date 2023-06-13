using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();

            IQuit quit = new Employee();

            quittable.Quit();

            Console.ReadLine();

            Employee employee1 = new Employee();
            employee.ID = 2365;
            employee1.ID = 2365;

            if (employee == employee1)
            {
                Console.WriteLine("\nThe IDs are a match.");
            }
            else
            {
                Console.WriteLine("\nThe IDs do not match.");
            }

            Console.ReadLine();

            // Begin Lambda Assignment
            // Creating 10 new Employees
            Employee JohnCena = new Employee() { FirstName = "John", LastName = "Cena", ID = 1 };
            Employee MarkyMark = new Employee() { FirstName = "Marky", LastName = "Mark", ID = 2 };
            Employee JoeDirte = new Employee() { FirstName = "Joe", LastName = "Dirte", ID = 3 };
            Employee DonJuan = new Employee() { FirstName = "Don", LastName = "Juan", ID = 4 };
            Employee FortNite = new Employee() { FirstName = "Fort", LastName = "Nite", ID = 5 };
            Employee GenShin = new Employee() { FirstName = "Gen", LastName = "Shin", ID = 6 };
            Employee HannahMontana = new Employee() { FirstName = "Hannah", LastName = "Montana", ID = 7 };
            Employee ThatGuy = new Employee() { FirstName = "That", LastName = "Guy", ID = 8 };
            Employee UrNot = new Employee() { FirstName = "Ur", LastName = "Not", ID = 9 };
            Employee JohnWayne = new Employee() { FirstName = "John", LastName = "Wayne", ID = 10 };

            // Adding employees to list
            List<Employee> employees = new List<Employee>()
            {
                JohnCena, MarkyMark, JoeDirte, DonJuan, FortNite, GenShin, HannahMontana, ThatGuy, UrNot, JohnWayne
            };

            // foreach loop to find all named "Joe"
            foreach (Employee worker in employees)
            {
                if (worker.FirstName == "Joe")
                {
                    List<Employee> joes = new List<Employee>() { worker };
                    Console.WriteLine("\n-First Name: \"" + worker.FirstName + "\" -Last Name: \"" + worker.LastName + "\" -ID: \"" + worker.ID + "\"");
                }
            }

            Console.ReadLine();

            // Lambda to find all named "Joe" and add them to list
            List<Employee> joes2 = employees.Where(x => x.FirstName == "Joe").ToList();

            // Prints them to screen
            foreach (Employee joe in joes2)
            {
                Console.WriteLine("\n-First Name: \"" + joe.FirstName + "\" -Last Name: \"" + joe.LastName + "\" -ID: \"" + joe.ID + "\"");
            }

            Console.ReadLine();

            // Lambda to find all IDs greater than 5
            List<Employee> IDs = employees.Where(x => x.ID > 5).ToList();

            // Prints them to screen
            foreach (Employee id in IDs)
            {
                Console.WriteLine("\n-First Name: \"" + id.FirstName + "\" -Last Name: \"" + id.LastName + "\" -ID: \"" + id.ID + "\"");
            }
            // End Lambda Assignment

            Console.Read();
        }
    }
}

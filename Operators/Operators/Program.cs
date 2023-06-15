using System;
using System.Collections.Generic;
// Added system.collections.generic

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();  
            Employee employee2 = new Employee();    

            employee.FirstName = new List<string>() { "David" }; 
            employee.LastName = new List<string>() { "Goggins" }; 
            employee.Id = 1;    //add value of 1 to employee property 


            employee2.FirstName = new List<string>() { "Mori" }; 
            employee2.LastName = new List<string>() { "Jinn" }; 
            employee2.Id = 2;   //add value of 2 to employee2 property




            Console.WriteLine((employee == employee2)); // The result displays if equal, could also return != if not equal 

            Console.ReadLine(); 

        }
    }
}

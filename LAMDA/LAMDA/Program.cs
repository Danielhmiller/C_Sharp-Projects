using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee> { new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee() }; // 10 employees
            employeeList[0].FirstName = "Joe";
            employeeList[0].Id = 5;

            employeeList[1].FirstName = "David'";
            employeeList[1].Id = 6;

            employeeList[2].FirstName = "Joe";
            employeeList[2].Id = 7;

            List<Employee> joeList = new List<Employee>();

            foreach (Employee employee in employeeList)
            {

                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                    //Console.WriteLine(employee.FirstName);  // test result
                }

            }

            List<Employee> newjoeList = employeeList.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> idjoeList = employeeList.Where(x => x.Id > 5).ToList(); // Lambda to return Id greater than 5
            //Console.WriteLine(idJOEList[0].Id + ", " + idJOEList[1].Id);  // test result

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var studentCtx = new StudentContext())
            {
                var student = new Student() { StudentId = 0, StudentFName = "Daniel", StudentLName = "Miller", StudentGrade = 10 };

                studentCtx.students.Add(student);
                studentCtx.SaveChanges();
            }
        }
    }
}

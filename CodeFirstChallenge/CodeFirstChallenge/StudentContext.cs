using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstChallenge
{
    class StudentContext : DbContext
    {
        public StudentContext(): base()
        {

        }

        public DbSet<Student> students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}

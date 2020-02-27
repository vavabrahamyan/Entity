using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Entity
{
    class StudentContext:DbContext
    {
        public StudentContext() : base("Shahane") { }

        public DbSet<Student> Students { get; set; }
    }
}

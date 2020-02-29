using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202_Entity_Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( var db  = new TeacherContext("connectionString"))
            {
                var t1 = new Teacher { Name = "A1", Age = 35 };

                db._DbSet.Add(t1);
                db.SaveChanges();
            }
        }
    }
}

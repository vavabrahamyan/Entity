using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202_Entity_Repository
{
    class StudentContext:_Context<Student>
    {
        public StudentContext(string connectionString):base(connectionString)
        {

        }
    }
}

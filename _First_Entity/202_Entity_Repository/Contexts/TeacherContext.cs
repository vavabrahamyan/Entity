using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202_Entity_Repository
{
    class TeacherContext:_Context<Teacher>
    {
        public TeacherContext(string connectionString) : base(connectionString)
        {

        }
    }
}

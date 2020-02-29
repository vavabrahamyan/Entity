using System.Data.Entity;

namespace _003_Entity_Reading
{
    class StudentContext:DbContext
    {
        public StudentContext() : base("Shahane") { }

        public DbSet<Student> Students { get; set; }
    }
}

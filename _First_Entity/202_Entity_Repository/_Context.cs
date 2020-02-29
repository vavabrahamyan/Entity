using System.Data.Entity;

namespace _202_Entity_Repository
{
    class _Context<T>:DbContext where T:class
    {
        public _Context(string connectionString) : base(connectionString) { }

        public DbSet<T> _DbSet { get; set; }
    }
}

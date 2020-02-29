using System.Data.Entity;

namespace _101_Entity_independent
{
    class UserContext:DbContext
    {
        public UserContext() : base("connectionString") { }

        public DbSet<User> Users { get; set; }
    }
}

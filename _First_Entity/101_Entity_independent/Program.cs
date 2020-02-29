using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_Entity_independent
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserContext())
            {
                db.Users.Add(new User { Name = "Vahe", Company = "Google" });
                db.Users.Add(new User { Name = "Gago", Company = "Microsoft" });
                db.Users.Add(new User { Name = "Vardges", Company = "Sil" });
                db.Users.Add(new User { Name = "Davit", Company = "Google" });
                db.Users.Add(new User { Name = "Aram", Company = "Google" });

                db.SaveChanges();
            }
        }
    }
}

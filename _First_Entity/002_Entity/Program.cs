namespace _002_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StudentContext sc = new StudentContext())
            {
                var st1 = new Student { Name = "Vahe", Age = 25 };


                sc.Students.Add(st1);
                sc.SaveChanges();
            }
        }
    }
}

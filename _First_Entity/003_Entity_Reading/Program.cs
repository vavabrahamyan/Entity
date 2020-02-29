namespace _003_Entity_Reading
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var st = new StudentContext())
            {
                var students = st.Students;
                foreach (var item in students)
                {
                    System.Console.WriteLine($"Age:{item.Age}\tName:{item.Name}");
                }
            }
        }
    }
}

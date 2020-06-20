using EF6CodeFirst.Context;
using EF6CodeFirst.Models.Business;

namespace EF6CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Jakku" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}

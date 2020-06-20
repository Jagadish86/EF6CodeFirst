using EF6CodeFirst.Models.Business;
using System.Data.Entity;

namespace EF6CodeFirst.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=EFCodeFirst")
        {
            //Database.SetInitializer<SchoolContext>(null);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, EF6CodeFirst.Migrations.Configuration>());
            //Database.SetInitializer<SchoolContext>(new CreateDatabaseIfNotExists<SchoolContext>);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentM> StudentM { get; set; }
    }
}

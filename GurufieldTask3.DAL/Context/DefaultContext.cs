using System.Data.Entity;
using GurufieldTask3.DAL.Entities;

namespace GurufieldTask3.DAL.Context
{
    public class DefaultContext : DbContext
    {
        static DefaultContext()
        {
            Database.SetInitializer<DefaultContext>(new StoreDbInitializer());
        }

        public DefaultContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Person> Peoples { get; set; }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DefaultContext>
    {
        protected override void Seed(DefaultContext db)
        {
            db.Peoples.Add(new Person {Name = "Andriy", Age = 31});
            db.Peoples.Add(new Person {Name = "Victor", Age = 27});
            db.Peoples.Add(new Person {Name = "Ivan", Age = 36});
            db.SaveChanges();
        }
    }
}
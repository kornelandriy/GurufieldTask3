using GurufieldTask3.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GurufieldTask3.DAL.Context
{
    public class DefaultContext : DbContext
    {
//        private IConfiguration _configuration;
//        public DefaultContext(IConfiguration configuration): base()
//        {
//            _configuration = configuration;
//        }
        public DbSet<Person> Peoples { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=peoples;Trusted_Connection=True;");
//            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnectionString"));
        }

    }
}
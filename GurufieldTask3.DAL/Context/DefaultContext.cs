using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GurufieldTask3.DAL.Context
{
    public class DefaultContext : DbContext
    {
        private readonly IDataOptions _configuration;

        public DefaultContext(IDataOptions configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Person> Peoples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.ConnectionString);
        }
    }
}
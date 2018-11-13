using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GurufieldTask3.DAL.Context
{
    public class DefaultContext : DbContext
    {
        private readonly IConfigurations _configuration;

        public DefaultContext(IConfigurations configuration)
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
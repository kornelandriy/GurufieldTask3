using GurufieldTask3.DAL.Interfaces;

namespace GurufieldTask3.DAL.Infrastructure
{
    public class Configurations : IConfigurations
    {
        public Configurations(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
    }
}
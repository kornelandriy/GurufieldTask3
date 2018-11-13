using GurufieldTask3.DAL.Interfaces;

namespace GurufieldTask3.DAL.Infrastructure
{
    public class DatabaseOptions : IDataOptions
    {
        public DatabaseOptions(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
    }
}
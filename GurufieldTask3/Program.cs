using System.IO;
using GurufieldTask3.DAL.Infrastructure;
using GurufieldTask3.DAL.Interfaces;
using GurufieldTask3.DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GurufieldTask3
{
    internal class Program
    {
        public static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            serviceProvider.GetService<App>().Run();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            var configuration = builder.Build();
            serviceCollection.AddTransient<IDataOptions>(s =>
                new DatabaseOptions(configuration.GetConnectionString("DefaultConnection")));
            serviceCollection.AddTransient<IUnitOfWork, EfUnitOfWork>();
            serviceCollection.AddTransient<App>();
        }
    }
}
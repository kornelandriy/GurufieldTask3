using System;
using System.Linq;
using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;

namespace GurufieldTask3
{
    public class App
    {
        private readonly IUnitOfWork _dataAccessService;

        public App(IUnitOfWork dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        public void Run()
        {
            _dataAccessService.Peoples.Create(new Person { Name = "Ivan", Age = 25});
            _dataAccessService.Save();

            foreach (var person in _dataAccessService.Peoples.GetAll())
            {
                Console.WriteLine($"Person #{person.Id}, Name={person.Name}");
            }
            
            Console.ReadKey();
        }
    }
}
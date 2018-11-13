using System;
using System.Linq;
using GurufieldTask3.DAL.Interfaces;

namespace GurufieldTask3
{
    public class App
    {
        private readonly IUnitOfWork _repositoryService;

        public App(IUnitOfWork repositoryService)
        {
            _repositoryService = repositoryService;
        }

        public void Run()
        {
            var x = _repositoryService.Peoples.GetAll().ToList();

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;
using GurufieldTask3.Extensions;

namespace GurufieldTask3
{
    public class App
    {
        private readonly IUnitOfWork _unitOfWork;

        public App(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Run()
        {
            AddPerson(new Person {Name = "Ivan", Age = 25});
            AddPerson(new Person {Name = "Andriy", Age = 37});

            GetPeoples().ToScreen();
            
            Console.ReadKey();
        }

        private void AddPerson(Person person)
        {
            _unitOfWork.Peoples.Create(person);
            _unitOfWork.Save();
        }

        private IEnumerable<Person> GetPeoples()
        {
            return _unitOfWork.Peoples.GetAll();
        }
    }
}
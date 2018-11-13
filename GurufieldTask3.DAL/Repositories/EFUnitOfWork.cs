using System;
using GurufieldTask3.DAL.Context;
using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;

namespace GurufieldTask3.DAL.Repositories
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly DefaultContext _defaultContext;
        private PersonRepository _personRepository;

        public EfUnitOfWork(IConfigurations configurations)
        {
            _defaultContext = new DefaultContext(configurations);
        }

        public IRepository<Person> Peoples =>
            _personRepository ?? (_personRepository = new PersonRepository(_defaultContext));

        public void Save()
        {
            _defaultContext.SaveChanges();
        }

        public void Dispose()
        {
            _defaultContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
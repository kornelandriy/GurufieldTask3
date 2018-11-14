using System;
using GurufieldTask3.DAL.Context;
using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;

namespace GurufieldTask3.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DefaultContext _defaultContext;
        private PersonRepository _personRepository;

        private bool _disposed;

        public UnitOfWork(IConfigurations configurations)
        {
            _defaultContext = new DefaultContext(configurations);
        }

        public IRepository<Person> Peoples =>
            _personRepository ?? (_personRepository = new PersonRepository(_defaultContext));

        public void Save()
        {
            _defaultContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing) _defaultContext.Dispose();
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
using System;
using GurufieldTask3.DAL.Context;
using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GurufieldTask3.DAL.Repositories
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private PersonRepository _personRepository;
        private readonly DefaultContext _defaultContext;

        private bool _disposed;

        public EfUnitOfWork()
        {
            _defaultContext = new DefaultContext();
        }

        public IRepository<Person> Peoples
        {
            get { return _personRepository ?? (_personRepository = new PersonRepository(_defaultContext)); }
        }

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
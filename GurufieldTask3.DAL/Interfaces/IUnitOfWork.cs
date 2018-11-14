using System;
using GurufieldTask3.DAL.Entities;

namespace GurufieldTask3.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Person> Peoples { get;}
        void Save();
    }
}
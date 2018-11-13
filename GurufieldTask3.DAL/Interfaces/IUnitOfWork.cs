using GurufieldTask3.DAL.Entities;

namespace GurufieldTask3.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Person> Peoples { get;}
        void Save();
    }
}
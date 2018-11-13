using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GurufieldTask3.DAL.Context;
using GurufieldTask3.DAL.Entities;
using GurufieldTask3.DAL.Interfaces;

namespace GurufieldTask3.DAL.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        private readonly DefaultContext _defaultContext;

        public PersonRepository(DefaultContext context)
        {
            _defaultContext = context;
        }

        public IEnumerable<Person> GetAll()
        {
            return _defaultContext.Peoples;
        }

        public Person Get(int id)
        {
            return _defaultContext.Peoples.Find(id);
        }

        public void Create(Person book)
        {
            _defaultContext.Peoples.Add(book);
        }

        public void Update(Person book)
        {
            _defaultContext.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Person> Find(Func<Person, bool> predicate)
        {
            return _defaultContext.Peoples.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            var book = _defaultContext.Peoples.Find(id);
            if (book != null)
                _defaultContext.Peoples.Remove(book);
        }
    }
}
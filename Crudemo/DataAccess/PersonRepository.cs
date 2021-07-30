using Crudemo.DataAccess.Interfaces;
using Crudemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crudemo.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        public void Delete(int id, string concurrencyToken)
        {
            throw new NotImplementedException();
        }

        public void Delete(Person model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> Get()
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Person model)
        {
            throw new NotImplementedException();
        }

        public void Update(Person model)
        {
            throw new NotImplementedException();
        }
    }
}

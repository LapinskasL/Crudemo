using Crudemo.API.Models;
using Crudemo.API.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudemo.API.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public void Delete(int id)
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

        public void Update(Person model)
        {
            throw new NotImplementedException();
        }
    }
}

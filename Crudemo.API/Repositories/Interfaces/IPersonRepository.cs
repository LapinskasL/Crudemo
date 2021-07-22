using Crudemo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudemo.API.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Get();
        Person Get(int id);
        void Update(Person model);
        void Delete(int id);
    }
}

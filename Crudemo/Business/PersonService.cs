using Crudemo.Business.Interfaces;
using Crudemo.Business.Responses;
using Crudemo.DataAccess.Interfaces;
using Crudemo.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crudemo.Business
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository = 
            RestService.For<IPersonRepository>("https://localhost:44313/api");
        public PersonService()
        {
                
        }
        public PersonResponse Delete(int id, string concurrencyToken)
        {
            throw new NotImplementedException();
        }

        public PersonResponse Delete(Person model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Person>> Get()
        {
            IEnumerable<Person> models = await _personRepository.Get();
            return models;
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public PersonResponse Insert(Person model)
        {
            throw new NotImplementedException();
        }

        public PersonResponse Update(Person model)
        {
            throw new NotImplementedException();
        }
    }
}

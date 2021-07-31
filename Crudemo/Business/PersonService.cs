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
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<PersonResponse> Delete(int id)
        {
            await _personRepository.Delete(id);
            return new PersonResponse
            {
                IsSuccessful = true
            };
        }

        public async Task<IEnumerable<Person>> Get()
        {
            IEnumerable<Person> models = await _personRepository.Get();
            return models;
        }

        public async Task<Person> Get(int id)
        {
            Person model = await _personRepository.Get(id);
            return model;
        }

        public async Task<PersonResponse> Insert(Person model)
        {
            Person insertedModel = await _personRepository.Insert(model);
            return new PersonResponse
            {
                IsSuccessful = true,
                Person = insertedModel
            };
        }

        public async Task<PersonResponse> Update(Person model)
        {
            await _personRepository.Update(model);
            return new PersonResponse
            {
                IsSuccessful = true,
                Person = await _personRepository.Get(model.Id)
            };
        }
    }
}

using Crudemo.DataAccess.ApiClients;
using Crudemo.DataAccess.Interfaces;
using Crudemo.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crudemo.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ICrudemoApi _crudemoApi;

        public PersonRepository(ICrudemoApi crudemoApi)
        {
            _crudemoApi = crudemoApi;
        }

        public async Task Delete(int id)
        {
            await _crudemoApi.Delete(id);
        }

        public async Task<IEnumerable<Person>> Get()
        {
            IEnumerable<Person> models = await _crudemoApi.Get();
            return models;
        }

        public async Task<Person> Get(int id)
        {
            Person model = await _crudemoApi.Get(id);
            return model;
        }

        public async Task<Person> Insert(Person model)
        {
            Person insertedModel = await _crudemoApi.Insert(model);
            return insertedModel;
        }

        public async Task Update(Person model)
        {
            await _crudemoApi.Update(model);
        }
    }
}

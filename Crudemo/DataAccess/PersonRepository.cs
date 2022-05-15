using Crudemo.DataAccess.ApiClients;
using Crudemo.DataAccess.Interfaces;
using Crudemo.Models;
using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crudemo.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ICrudemoApi _crudemoApi;
        private readonly ILogger<PersonRepository> _logger;

        public PersonRepository(ICrudemoApi crudemoApi, ILogger<PersonRepository> logger)
        {
            _crudemoApi = crudemoApi;
            _logger = logger;
        }

        public async Task Delete(int id)
        {
            await _crudemoApi.Delete(id);
            _logger.LogInformation("Person deleted.");
        }

        public async Task<IEnumerable<Person>> Get()
        {
            var response = await _crudemoApi.Get();
            _logger.LogInformation("Retrieved {count} persons.", response.Content.ToList().Count);
            return response.Content;
        }

        public async Task<Person> Get(int id)
        {
            var response = await _crudemoApi.Get(id);
            return response.Content;
        }

        public async Task<Person> Insert(Person model)
        {
            var response = await _crudemoApi.Insert(model);
            _logger.LogInformation("Person inserted.");
            return response.Content;
        }

        public async Task Update(Person model)
        {
           var response = await _crudemoApi.Update(model);
            _logger.LogInformation("Person updated.");
        }
    }
}

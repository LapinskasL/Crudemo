using Crudemo.API.Models.Person;
using Crudemo.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crudemo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Person> models = _personRepository.Get();
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Person model = _personRepository.Get(id);
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person model)
        {
            int insertedId = _personRepository.Insert(model);
            return CreatedAtAction(nameof(Get), new { id = insertedId }, model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person model)
        {
            _personRepository.Update(model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personRepository.Delete(id);
            return NoContent();
        }
    }
}

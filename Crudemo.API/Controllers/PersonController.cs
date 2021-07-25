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
            //TODO add dto mapping
            return Ok(models);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Person model = _personRepository.Get(id);
            if (model == null)
            {
                return NotFound();
            }
            //TODO add dto mapping
            return Ok(model);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person model)
        {
            int insertedId = _personRepository.Insert(model);
            Person insertedPerson = _personRepository.Get(insertedId);
            //TODO add dto mapping
            return CreatedAtAction(nameof(Get), new { id = insertedId }, insertedPerson);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person model)
        {
            Person person = _personRepository.Get(id);
            if (person == null)
            {
                return NotFound();
            }
            _personRepository.Update(model);
            return Ok();//TODO return model
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Person person = _personRepository.Get(id);
            if (person == null)
            {
                return NotFound();
            }
            _personRepository.Delete(id);
            return NoContent();
        }
    }
}

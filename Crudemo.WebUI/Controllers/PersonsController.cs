using AutoMapper;
using Crudemo.Business.Interfaces;
using Crudemo.Business.Responses;
using Crudemo.Models;
using Crudemo.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudemo.WebUI.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonsController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetPersons()
        {
            return Json(new { data = await _personService.Get() });
        }

        [HttpGet]
        public PartialViewResult GetUpsertPersonFormPartial(PersonModel viewModel = null)
        {
            //instead of requerying the person, we bind the whole model so
            //the object's update form's values reflect those in the table
            if (viewModel == null)
            {
                return PartialView("_UpsertPersonFormPartial");
            }

            return PartialView("_UpsertPersonFormPartial", viewModel);
        }

        [HttpPost]
        public async Task<JsonResult> UpsertPerson(PersonModel viewModel)
        {
            Person model = _mapper.Map<Person>(viewModel);

            PersonResponse response;
            if (viewModel.Id == 0)
            {
                response = await _personService.Insert(model);
            }
            else
            {
                response = await _personService.Update(model);
            }

            return Json(response);
        }

        [HttpPost]
        public async Task<JsonResult> DeletePerson(PersonModel viewModel)
        {
            PersonResponse response = await _personService.Delete(viewModel.Id);
            return Json(response);
        }
    }
}

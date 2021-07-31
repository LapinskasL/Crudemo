using Crudemo.Business.Interfaces;
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

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<IActionResult> Index()
        {
            await _personService.Get();
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetPersons()
        {
            return Json(new { data = await _personService.Get() });
        }

        [HttpGet]
        public PartialViewResult GetUpsertPersonFormPartial(PersonModel model = null)
        {
            //instead of requerying the person, we bind the whole model so
            //the object's update form's values reflect those in the table
            if (model == null)
            {
                return PartialView("_UpsertPersonFormPartial");
            }

            return PartialView("_UpsertPersonFormPartial", model);
        }

        [HttpPost]
        public JsonResult UpsertPerson(PersonModel model)
        {
            if (model.Id == 0)
            {
                //TODO insert person
                return Json(new { });
            }

            //TODO update person
            return Json(new { });
        }

        [HttpPost]
        public JsonResult DeletePerson(PersonModel model)
        {
            //TODO delete person
            return Json(new { });
        }
    }
}

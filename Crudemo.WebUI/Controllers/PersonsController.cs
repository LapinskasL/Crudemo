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
        private List<PersonModel> GeneratePersons()
        {
            List<PersonModel> persons = new List<PersonModel>();
            for (int i = 0; i < 30; i++)
            {
                persons.Add(new PersonModel
                {
                    Id = i + 1,
                    FirstName = "First" + i.ToString(),
                    LastName = "Last" + i.ToString(),
                    PhoneNumber = "123456789" + i.ToString(),
                    ConcurrencyToken = "",
                    DateAdded = DateTime.Now
                });
            }

            return persons;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetPersons()
        {
            return Json(new { data = GeneratePersons() });
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
                //TODO insert person and return
                return Json(new { });
            }

            //TODO update person and return
            return Json(new { });
        }
    }
}

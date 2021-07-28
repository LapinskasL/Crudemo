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
        public PartialViewResult GetUpsertPersonFormPartial(int? personId)
        {
            if (personId == null)
            {
                return PartialView("_UpsertPersonFormPartial");
            }
            //TODO get person by Id
            return PartialView("_UpsertPersonFormPartial", GeneratePersons().First());
        }

        [HttpPost]
        public JsonResult UpsertPerson(PersonModel model)
        {
            if (model.Id == 0)
            {
                //TODO insert person and return
                return Json(new { });
            }

            //TODO insert person and return
            return Json(new { });
        }
    }
}

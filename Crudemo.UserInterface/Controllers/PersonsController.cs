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
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetPersons()
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

            return Json(new { data = persons });
        }
    }
}

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
    }
}

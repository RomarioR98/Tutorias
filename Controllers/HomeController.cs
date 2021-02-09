using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Repositories;

namespace Tutorias.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("RegistroAlumnos")]
        public IActionResult RegistroAlumnos()
        {
            return View();
        }
        [Route("RegistroMaestros")]
        public IActionResult RegistroMaestros()
        {
            return View();
        }
    }
}

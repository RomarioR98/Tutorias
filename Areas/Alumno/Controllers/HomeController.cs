using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorias.Areas.Alumno.Controllers
{
    [Area("Alumno")]
    public class HomeController : Controller
    {
        [Route("Alumno/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

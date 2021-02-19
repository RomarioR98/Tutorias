using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tutorias.Models;
using Tutorias.Repositories;

namespace Tutorias.Areas.Alumno.Controllers
{
    [Area("Alumno")]
    //AGREGAR LOS ROLES QUE PUEDEN INICIAR SESION SEPARADOS POR COMAS
    [Authorize(Roles = "Alumno")]
    public class HomeController : Controller
    {
        [Route("Alumno/")]
        [Route("Alumno/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

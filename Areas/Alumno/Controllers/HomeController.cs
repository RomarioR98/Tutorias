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
using Newtonsoft.Json;
using Tutorias.Models;
using Tutorias.Repositories;

namespace Tutorias.Areas.Alumno.Controllers
{
    [Area("Alumno")]

    //AGREGAR LOS ROLES QUE PUEDEN INICIAR SESION SEPARADOS POR COMAS
    [Authorize(Roles = "Alumno")]

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var datos = TempData["data"] as string;
            AlumnoRepository repo = new AlumnoRepository();
            var a = repo.GetAlumno(datos);
            return View(a);
        }
    }
}

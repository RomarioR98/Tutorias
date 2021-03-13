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
using Microsoft.AspNetCore.Routing;
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
        public IActionResult Index(string Id)
        {

           

            AlumnoRepository repo = new AlumnoRepository();
            var a = repo.GetAlumnoById(Id);
            return View(a);
        }
   
        public IActionResult Editar(string Id)
        {
           
            AlumnoRepository repo = new AlumnoRepository();
           var alumno= repo.GetAlumnoViewModelById(Id);
            if (alumno!=null)
            {
                return View(alumno);
            }

            return RedirectToAction("Index", "Alumno");
        }
    }
}

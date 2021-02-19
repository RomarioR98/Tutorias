using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Repositories;
using Tutorias.Models;


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



        [Route("RegistroAlumnos")]
        [HttpPost]
        public IActionResult RegistroAlumnos(AlumnoViewModel alumno)
        {
            if (alumno != null)
            {
                string error = Validar(alumno);

                if (error != "")
                {
                    ModelState.AddModelError("Error", error);
                    return View(alumno);
                }

                try
                {
                    AlumnoRepository repos = new AlumnoRepository();
                    repos.InsertAlumno(alumno);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                    return View(alumno);

                }
            }

            return RedirectToAction("Index");
        }

        [Route("RegistroMaestros")]
        public IActionResult RegistroMaestros()
        {
            return View();
        }



        string Validar(AlumnoViewModel alumno)
        {
            if (string.IsNullOrEmpty(alumno.NumeroControl))
                return "Proporcione su numero de control";
            if ((alumno.NumeroControl).Length != 8)
                return "Verifique su numero de control";
            if (string.IsNullOrEmpty(alumno.Nombres))
                return "Proporcione su nombre";
            if (string.IsNullOrEmpty(alumno.ApPaterno))
                return "Proporcione su apellido paterno";
            if (string.IsNullOrEmpty(alumno.ApMaterno))
                return "Proporcione su apellido materno";
            if (string.IsNullOrEmpty(alumno.Email))
                return "Proporcione su email";
            if (string.IsNullOrEmpty(alumno.Contraseña))
                return "Proporcione su contraseña";
            if (alumno.IdSemestre == 0)
                return "Proporcione su semestre";
            if (alumno.IdCarrera == 0)
                return "Proporcione su carrera";

            return "";

        }
    }
}

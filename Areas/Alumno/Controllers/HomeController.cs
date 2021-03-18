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
using Tutorias.Models;
using Tutorias.Repositories;



namespace Tutorias.Areas.Alumno.Controllers
{
    [Area("Alumno")]

    //AGREGAR LOS ROLES QUE PUEDEN INICIAR SESION SEPARADOS POR COMAS
    [Authorize(Roles = "Alumno")]

    public class HomeController : Controller
    {
        [Route("/Alumno/Index/{Id}")]
        public IActionResult Index(string Id)
        {
            AlumnoRepository repo = new AlumnoRepository();
            var a = repo.GetAlumnoById(Id);
            return View(a);
        }
        ////[Route("/Alumno/Editar")]
        //[Route("/Alumno/Editar/{Id}")]
        //public IActionResult Editar(string Id )
        //{
        //AlumnoRepository repos = new AlumnoRepository();

        //    var e = repos.GetAlumnoViewModelById(Id);


        //    if (e == null)
        //    {
        //        return RedirectToAction("Index","Alumno");
        //    }
        //    else
        //    {
        //        return View(e);
        //    }
        //}


        //[HttpPost]
        //public IActionResult Editar(AlumnoViewModel a)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            AlumnoRepository repos = new AlumnoRepository();

        //            repos.UpdateAlumno(a);
        //            return RedirectToAction("Index","Alumno");
        //        }
        //        catch (Exception ex)
        //        {
        //            ModelState.AddModelError("", ex.Message);
        //            return View(a);
        //        }
        //    }
        //    else
        //    {
        //        return View(a);
        //    }

        //}
        [Route("/Alumno/Eliminar/{Id}")]
        [HttpGet]
        public IActionResult Eliminar(string Id)
        {
            AlumnoRepository repo = new AlumnoRepository();
            repo.DeleteAlumno(Id);
            return RedirectToAction("Index");

        }

        [Route("/Alumno/Materias/{Id}")]
        public IActionResult Materias(string Id)
        {
            AlumnoRepository repo = new AlumnoRepository();
            var a = repo.GetAlumnosMateriaById(Id);
            return View(a);
        }
        [Route("/Alumno/Materias/Agregar")]
        public IActionResult AgregarMateriaAlum()
        {
            return View();
        }

        [Route("/Alumno/Materias/Agregar")]
        [HttpPost]
        public IActionResult AgregarMateriaAlum(AlumnosMateriaViewModel vm)
        {
            if(vm!=null)
            {
                AlumnosMateriaRepository repo = new AlumnosMateriaRepository();
                repo.InsertAlumnosMateria(vm);


            }
            return RedirectToAction("Materias","Alumno", new {Id=vm.IdAlumno });
        }
        string Validar(AlumnoViewModel alumno)
        {
            if (string.IsNullOrEmpty(alumno.NumeroControl))
                return "Proporcione su numero de control";
            if ((alumno.NumeroControl).Length != 8)
                return "Verifique su numero de control";
            if (string.IsNullOrEmpty(alumno.Nombre))
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

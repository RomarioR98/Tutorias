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

namespace Tutorias.Areas.Maestro.Controllers
{
    [Area("Maestro")]

    //AGREGAR LOS ROLES QUE PUEDEN INICIAR SESION SEPARADOS POR COMAS
    [Authorize(Roles = "Maestro")]
    public class HomeController : Controller
    {
        public IActionResult Index(string Id)
        {
            ////MateriasRepository repos = new MateriasRepository();
            ////return View(repos.GetMateriasByMaestro(id));
            //var datos = TempData["data"] as string;
            MaestroRepository repo = new MaestroRepository();
            var a = repo.GetMaestroById(Id);
            return View(a);
        }

        public IActionResult Editar(string Id)
        {

            MaestroRepository repo = new MaestroRepository();
            var maestro = repo.GetMaestroViewModelById(Id);
            if (maestro != null)
            {
                return View(maestro);
            }

            return RedirectToAction("Index", "Maestro");
        }
    }
}

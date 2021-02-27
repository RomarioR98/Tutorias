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
        public IActionResult Index(string id)
        {
            MateriasRepository repos = new MateriasRepository();
            return View(repos.GetMateriasByMaestro(id));
        }
    }
}

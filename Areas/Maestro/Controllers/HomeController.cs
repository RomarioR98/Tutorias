using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Areas.Maestro;
using Tutorias.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tutorias.Areas.Maestro.Controllers
{
    [Area("Maestro")]

    //AGREGAR LOS ROLES QUE PUEDEN INICIAR SESION SEPARADOS POR COMAS
    //[Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        [Route("Maestro/Index/{id}")]
        public IActionResult Index(string id)
        {
            MateriasRepository repos = new MateriasRepository();
            return View(repos.GetMateriasByMaestro(id));
        }
    }
}

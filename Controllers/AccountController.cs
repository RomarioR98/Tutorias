using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Tutorias.Models;

namespace Tutorias.Controllers
{
    public class AccountController : Controller
    {
		//[Route("Login/Alumno")]
		public IActionResult IndexAlumno()
		{
			return View();
		}

		//Accion para iniciar sesion como alumno
		//[Route("Login/Alumno")]
		[HttpPost]
		public async Task<IActionResult> IndexAlumno(string user, string password)
		{
			try
			{
				tutoriasContext context = new tutoriasContext();

				var usuario = context.Alumno.FirstOrDefault(x => x.NumeroControl == user && x.Contraseña == password);

				if (usuario == null)
				{
					ModelState.AddModelError("", "El usuario o la contraseña son incorrectos");
					return View();

				}
				else
				{
					var claims = new List<Claim>
						{
							new Claim(ClaimTypes.Name, usuario.NumeroControl),
							new Claim(ClaimTypes.Role, usuario.Rol),
							new Claim("Id", usuario.NumeroControl.ToString()),
						};
					ClaimsIdentity identity = new ClaimsIdentity(claims, "login");
					ClaimsPrincipal principal = new ClaimsPrincipal(identity);
					await HttpContext.SignInAsync(principal);
					return RedirectToAction("Index", "Alumno/Home");
				}
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", ex.Message);
				return View();
			}
		}

		//[Route("Login/Maestro")]
		public IActionResult IndexMaestro()
		{
			return View();
		}

		//Accion para iniciar sesion como maestro
		//[Route("Login/Maestro")]
		[HttpPost]
		public async Task<IActionResult> IndexMaestro(string user, string password)
		{
			try
			{
				tutoriasContext context = new tutoriasContext();

				var usuario = context.Maestro.FirstOrDefault(x => x.NumeroControl == user && x.Contraseña == password);

				if (usuario == null)
				{
					ModelState.AddModelError("", "El usuario o la contraseña son incorrectos");
					return View();

				}
				else
				{
					var claims = new List<Claim>
						{
							new Claim(ClaimTypes.Name, usuario.NumeroControl),
							new Claim(ClaimTypes.Role, usuario.Rol),
							new Claim("Id", usuario.NumeroControl.ToString()),
						};
					ClaimsIdentity identity = new ClaimsIdentity(claims, "login");
					ClaimsPrincipal principal = new ClaimsPrincipal(identity);
					await HttpContext.SignInAsync(principal);
					return RedirectToAction("Index", "Maestro/Home");
				}
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", ex.Message);
				return View();
			}
		}

		//[Route("Login/Denied")]
		public IActionResult Denied()
		{
			return View();
		}

		//Acccion para CerrarSesion
		public IActionResult Logout()
		{
			HttpContext.SignOutAsync();
			return RedirectToAction("Home");
		}
	}
}

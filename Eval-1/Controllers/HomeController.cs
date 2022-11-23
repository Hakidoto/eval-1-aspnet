using DBClassLib;
using Eval_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eval_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Nickname, string Passcode)
        {
            db_pruebaEntities db = new db_pruebaEntities();
            
            string user = Nickname;//
            string pass = Passcode;//

            //var usuario = from b in db.Usuarios
            //              where b.Usuario == user
            //              select b.IdUsuario;
            //var fetch = usuario.ToList();

            var puesto = (from users in db.Usuarios
                           where users.Usuario == user && users.Contrasena == pass
                           select users.IdUsuario).FirstOrDefault();

            if ( puesto == 1)
            {
                return RedirectToAction("Index", "JefeComputo");

            }
            else if (puesto == 2)
            {
                return RedirectToAction("Index", "JefeArea");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
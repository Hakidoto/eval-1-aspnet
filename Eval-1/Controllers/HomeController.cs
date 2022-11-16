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
            string user = Nickname;//
            string pass = Passcode;//

            if (user == "JefeComputo")
            {
                return View("~/Views/JefeComputo/Index.cshtml");
            }
            else if (user == "JefeArea")
            {
                return View("~/Views/JefeArea/Index.cshtml");
            }
            else
            {
                ViewBag.JavaScriptFunction = "$('#MyPopUp').modal('show')";
                System.Threading.Thread.Sleep(10000);
                return View("~/Views/Home/Index.cshtml");
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
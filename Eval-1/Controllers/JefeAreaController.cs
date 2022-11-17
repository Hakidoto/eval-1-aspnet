using Microsoft.AspNetCore.Mvc;
using Eval_1.Models;

namespace Eval_1.Controllers
{
    public class JefeAreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListTicket()
        {
            return View();
        }
    }
}

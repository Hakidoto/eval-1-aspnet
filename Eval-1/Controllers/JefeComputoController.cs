using DBClassLib;
using Microsoft.AspNetCore.Mvc;

namespace Eval_1.Controllers
{
    public class JefeComputoController : Controller
    {
        public IActionResult Index()
        {
            var entities = new db_pruebaEntities();
            return View(entities.Reporte.ToList());
        }
    }
}

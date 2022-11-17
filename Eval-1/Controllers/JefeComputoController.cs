using DBClassLib;
using Microsoft.AspNetCore.Mvc;

namespace Eval_1.Controllers
{
    public class JefeComputoController : Controller
    {
        public IActionResult Index()
        {
            db_pruebaEntities db = new db_pruebaEntities();
            return View(db.Reporte.ToList());
        }
    }
}

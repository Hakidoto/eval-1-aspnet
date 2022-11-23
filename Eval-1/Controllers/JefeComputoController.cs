using DBClassLib;
using Eval_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eval_1.Controllers
{
    public class JefeComputoController : Controller
    {
        ListReportModel reporte = new ListReportModel();
        public IActionResult Index()
        {
            return View(reporte.ListarReportes());
        }

        public ActionResult RemoveReport(int IdReporte)
        {
            reporte.Eliminar(IdReporte);

            return RedirectToAction(nameof(Index));
        }

        public ActionResult EditReport(string Equipo, string Accion, String Atencion)
        {
            Reporte itm = new Reporte();
            itm.Equipo = Equipo;
            itm.Accion = Accion;
            itm.Atencion = Atencion;
            reporte.Modificar(itm);
            return RedirectToAction("Index");

        }

    }
}

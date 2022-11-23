using Microsoft.AspNetCore.Mvc;
using Eval_1.Models;
using DBClassLib;

namespace Eval_1.Controllers
{
    public class JefeAreaController : Controller
    {
        ListReportModel reporte = new ListReportModel();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListTicket()
        {
            return View(reporte.ListarReportes());
        }

        public IActionResult AddTicket()
        {
            return View();
        }

        public IActionResult AddNewTicket(string Equipo, string Accion, String Atencion)
        {
            Reporte itm = new Reporte();
            itm.Equipo = Equipo;
            itm.Accion = Accion;
            itm.Atencion = Atencion;
            reporte.Agregar(itm);
            return RedirectToAction("ListTicket");
        }
    }
}

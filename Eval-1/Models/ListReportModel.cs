using DBClassLib;

namespace Eval_1.Models
{
    public class ListReportModel
    {
        db_pruebaEntities db = new db_pruebaEntities();
        public List<Reporte> ListarReportes()
        {
            var reportes = from p in db.Reporte select p;

            return reportes.ToList();
        }

        public void Agregar(Reporte itm)
        {
            var personas = new Reporte();

            db.Reporte.Add(itm);
            db.SaveChanges();
        }

        public void Eliminar(int IdReporte)
        {
            var reporte = (from p in db.Reporte where p.IdReporte == IdReporte select p).FirstOrDefault();


            db.Reporte.Remove(reporte);


            db.SaveChanges();

        }

        public void Modificar(Reporte itm)
        {
            var reporte = (from p in db.Reporte where p.IdReporte == itm.IdReporte select p).FirstOrDefault();

            reporte.IdReporte = itm.IdReporte;
            reporte.Accion = itm.Accion;
            reporte.Equipo = itm.Equipo;
            reporte.Atencion = itm.Atencion;

            db.SaveChanges();
        }
    }
}

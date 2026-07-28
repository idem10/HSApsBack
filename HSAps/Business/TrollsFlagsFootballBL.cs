using HSAps.Interfaces;
using HSAps.Models;
using HSAps.Models.HSAps;

namespace HSAps.Business
{
    public class TrollsFlagsFootballBL
    {
        private readonly ITrollsFlagsFootball _tff;
        public TrollsFlagsFootballBL(ITrollsFlagsFootball tff) => _tff = tff;
        public List<TffDashBoardClass> GetDashBoard()
        {
            try
            {
                List<TffDashBoardClass> tdbc = new List<TffDashBoardClass>();
                var data = _tff.GetIntegrantes();
                var asistencias = _tff.GetAsistencia(data.Select(x => x.Id).ToList());
                var pagos = _tff.GetPagos(data.Select(x => x.Id).ToList());
                data.ForEach(d =>
                {
                    var asistencia = asistencias.Where(x => x.IdInt == d.Id).ToList();
                    var pago = pagos.Where(x => x.IdInt == d.Id).ToList();
                    tdbc.Add(new TffDashBoardClass
                    {
                        Id = d.Id,
                        Nombre = d.Nombre,
                        Apellido = d.Apellido,
                        Fecha = d.Fecha,
                        Categoria = d.Categoria,
                        Activo = d.Activo,
                        Telefono = d.Telefono,
                        Email = d.Email,
                        Direccion = d.Direccion,
                        FechaIngreso = d.FechaIngreso,
                        Imagen = d.Imagen,
                        UltimoRegistro = asistencia.OrderByDescending(x => x.Id).Select(x => x.FechaRegistro).FirstOrDefault(),
                        Asistencias = asistencia,
                        UltimoPago = pago.OrderByDescending(x => x.Id).Select(x => x.FechaPago).FirstOrDefault(),
                        Pagos = pago
                    });
                });
                return tdbc;
            }
            catch
            {
                throw;
            }
        }

        //
        public TffIntegrante SetIntegrante(TffIntegrante ni)
        {
            try
            {
                return _tff.SetIntegrante(ni);
            }
            catch
            {
                throw;
            }
        }

        public TffPago SetPago(TffPago pago)
        {
            try
            {
                return _tff.SetPago(pago);
            }
            catch
            {
                throw;
            }
        }
        public TffAsistencium SetAsistencia(TffAsistencium asis)
        {
            try
            {
                return _tff.SetAsistencia(asis);
            }
            catch
            {
                throw;
            }
        }
        //
        public TffIntegrante DelIntegrante(TffIntegrante ni)
        {
            try
            {
                return _tff.DelIntegrante(ni);
            }
            catch
            {
                throw;
            }
        }
        public TffPago DelPago(TffPago pago)
        {
            try
            {
                return _tff.DelPago(pago);
            }
            catch
            {
                throw;
            }
        }
        public TffAsistencium DelAsistencia(TffAsistencium asis)
        {
            try
            {
                return _tff.DelAsistencia(asis);
            }
            catch
            {
                throw;
            }
        }
    }
}

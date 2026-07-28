using HSAps.Interfaces;
using HSAps.Models.HSAps;

namespace HSAps.Data
{
    public class TrollsFlagsFootballDL : ITrollsFlagsFootball
    {
        private readonly MapappContext _mkt = new MapappContext();
        //gets
        public List<TffIntegrante> GetIntegrantes()
        {
            try
            {
                return _mkt.TffIntegrantes.ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<TffAsistencium> GetAsistencia(List<int> ids)
        {
            try
            {
                return _mkt.TffAsistencia
                                .Where(x => ids.Contains(x.IdInt))
                                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<TffPago> GetPagos(List<int> ids)
        {
            try
            {
                return _mkt.TffPagos
                                .Where(x => ids.Contains(x.IdInt))
                                    .ToList();
            }
            catch
            {
                throw;
            }
        }
        //insert
        public TffIntegrante SetIntegrante(TffIntegrante ni)
        {
            try
            {
                var qry = _mkt.TffIntegrantes
                                .Where(x => x.Id == ni.Id)
                                    .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry == null)
                    {
                        insupt.TffIntegrantes.Add(ni);
                    }
                    else
                    {
                        qry.Nombre = ni.Nombre;
                        qry.Apellido = ni.Apellido;
                        qry.Fecha = ni.Fecha;
                        qry.Categoria = ni.Categoria;
                        qry.Activo = ni.Activo;
                        qry.Telefono = ni.Telefono;
                        qry.Email = ni.Email;
                        qry.Direccion = ni.Direccion;
                        qry.FechaIngreso = ni.FechaIngreso;
                    }
                    insupt.SaveChanges();
                }
                return ni;
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
                var qry = _mkt.TffPagos
                                .Where(x => x.Id == pago.Id)
                                    .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry == null)
                    {
                        insupt.TffPagos.Add(pago);
                    }
                    else
                    {
                        qry.IdInt = pago.IdInt;
                        qry.Monto = pago.Monto;
                        qry.Periodo = pago.Periodo;
                        qry.FechaPago = pago.FechaPago;
                        qry.Observaciones = pago.Observaciones;
                        qry.Adeudo = pago.Adeudo;
                        qry.FechaVencimiento = pago.FechaVencimiento;
                    }
                    insupt.SaveChanges();
                }
                return pago;
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
                var qry = _mkt.TffAsistencia
                                .Where(x => x.Id == asis.Id)
                                    .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry == null)
                    {
                        insupt.TffAsistencia.Add(asis);
                    }
                    else
                    {
                        qry.IdInt = asis.IdInt;
                        qry.FechaRegistro = asis.FechaRegistro;
                    }
                    insupt.SaveChanges();
                }
                return asis;
            }
            catch
            {
                throw;
            }
        }
        //dels
        public TffIntegrante DelIntegrante(TffIntegrante ni)
        {
            try
            {
                var qry = _mkt.TffIntegrantes
                                .Where(x => x.Id == ni.Id)
                                    .FirstOrDefault();
                using (var insupt = new MapappContext())
                {
                    if (qry != null)
                    {
                        insupt.TffIntegrantes.Remove(ni);
                        insupt.SaveChanges();
                    }
                }
                return ni;
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
                var qry = _mkt.TffPagos
                                .Where(x => x.Id == pago.Id)
                                    .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry != null)
                    {
                        insupt.TffPagos.Remove(pago);
                        insupt.SaveChanges();
                    }
                }
                return pago;
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
                var qry = _mkt.TffAsistencia
                                .Where(x => x.Id == asis.Id)
                                    .FirstOrDefault();
                using (var insupt = _mkt)
                {
                    if (qry != null)
                    {
                        insupt.TffAsistencia.Remove(asis);
                        insupt.SaveChanges();
                    }
                }
                return asis;
            }
            catch
            {
                throw;
            }
        }
    }
}

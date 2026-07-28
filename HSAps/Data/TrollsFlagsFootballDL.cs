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
                return _mkt.TffIntegrantes
                                .Where(x => x.Activo == 1)
                                    .ToList();
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
        //
    }
}

using HSAps.Models.HSAps;

namespace HSAps.Interfaces
{
    public interface ITrollsFlagsFootball
    {
        List<TffIntegrante> GetIntegrantes();
        List<TffAsistencium> GetAsistencia(List<int> ids);
        List<TffPago> GetPagos(List<int> ids);
    }
}

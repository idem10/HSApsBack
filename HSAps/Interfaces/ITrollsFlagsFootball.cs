using HSAps.Models.HSAps;

namespace HSAps.Interfaces
{
    public interface ITrollsFlagsFootball
    {
        List<TffIntegrante> GetIntegrantes();
        List<TffAsistencium> GetAsistencia(List<int> ids);
        List<TffPago> GetPagos(List<int> ids);
        //
        TffIntegrante SetIntegrante(TffIntegrante ni);
        TffPago SetPago(TffPago pago);
        TffAsistencium SetAsistencia(TffAsistencium asis);
        //
        TffIntegrante DelIntegrante(TffIntegrante ni);
        TffPago DelPago(TffPago pago);
        TffAsistencium DelAsistencia(TffAsistencium asis);
    }
}

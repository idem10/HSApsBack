using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsReporte
{
    public long ReporteId { get; set; }

    public long? UsuarioReportaId { get; set; }

    public long? PublicacionId { get; set; }

    public string? Motivo { get; set; }

    public DateTime? Fecha { get; set; }
}

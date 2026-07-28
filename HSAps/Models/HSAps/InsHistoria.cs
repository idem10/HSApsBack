using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsHistoria
{
    public long HistoriaId { get; set; }

    public long? UsuarioId { get; set; }

    public string? UrlArchivo { get; set; }

    public string? TipoArchivo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaExpiracion { get; set; }
}

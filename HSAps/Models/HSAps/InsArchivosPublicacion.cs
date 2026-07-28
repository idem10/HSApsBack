using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsArchivosPublicacion
{
    public long ArchivoId { get; set; }

    public long? PublicacionId { get; set; }

    public string? UrlArchivo { get; set; }

    public string? TipoArchivo { get; set; }

    public int? OrdenVisualizacion { get; set; }
}

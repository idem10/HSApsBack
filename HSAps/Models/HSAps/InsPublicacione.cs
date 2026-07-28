using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsPublicacione
{
    public long PublicacionId { get; set; }

    public long? UsuarioId { get; set; }

    public string? Descripcion { get; set; }

    public string? Ubicacion { get; set; }

    public DateTime? Fecha { get; set; }
}

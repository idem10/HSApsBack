using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsGuardado
{
    public long GuardadoId { get; set; }

    public long? UsuarioId { get; set; }

    public long? PublicacionId { get; set; }

    public DateTime? Fecha { get; set; }
}

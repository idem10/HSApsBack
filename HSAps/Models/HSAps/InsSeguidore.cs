using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsSeguidore
{
    public long SeguidorId { get; set; }

    public long? UsuarioOrigenId { get; set; }

    public long? UsuarioDestinoId { get; set; }

    public DateTime? Fecha { get; set; }
}

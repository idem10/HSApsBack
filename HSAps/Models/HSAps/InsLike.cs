using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsLike
{
    public long LikeId { get; set; }

    public long? PublicacionId { get; set; }

    public long? UsuarioId { get; set; }

    public DateTime? Fecha { get; set; }
}

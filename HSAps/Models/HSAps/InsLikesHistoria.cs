using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsLikesHistoria
{
    public long LikeHistoriaId { get; set; }

    public long? HistoriaId { get; set; }

    public long? UsuarioId { get; set; }

    public DateTime? Fecha { get; set; }
}

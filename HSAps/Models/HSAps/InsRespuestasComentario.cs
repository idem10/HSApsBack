using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsRespuestasComentario
{
    public long RespuestaId { get; set; }

    public long? ComentarioId { get; set; }

    public long? UsuarioId { get; set; }

    public string? Texto { get; set; }

    public DateTime? Fecha { get; set; }
}

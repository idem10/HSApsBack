using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsComentario
{
    public long ComentarioId { get; set; }

    public long? PublicacionId { get; set; }

    public long? UsuarioId { get; set; }

    public string? Comentario { get; set; }

    public DateTime? Fecha { get; set; }
}

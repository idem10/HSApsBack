using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsMensaje
{
    public long MensajeId { get; set; }

    public long? ConversacionId { get; set; }

    public long? UsuarioId { get; set; }

    public string? Texto { get; set; }

    public DateTime? Fecha { get; set; }

    public bool? Leido { get; set; }
}

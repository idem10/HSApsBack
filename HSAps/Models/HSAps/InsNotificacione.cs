using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsNotificacione
{
    public long NotificacionId { get; set; }

    public long? UsuarioId { get; set; }

    public string? Tipo { get; set; }

    public long? ReferenciaId { get; set; }

    public string? Mensaje { get; set; }

    public bool? Leida { get; set; }

    public DateTime? Fecha { get; set; }
}

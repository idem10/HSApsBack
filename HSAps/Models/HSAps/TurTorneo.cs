using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class TurTorneo
{
    public int Id { get; set; }

    public int Owner { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int Terminado { get; set; }

    public int Eliminado { get; set; }
}

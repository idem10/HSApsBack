using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class TurListaTorneo
{
    public int Id { get; set; }

    public int IdTorneo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ubicacion { get; set; } = null!;

    public string NumeroEquipos { get; set; } = null!;

    public decimal Apuesta { get; set; }

    public int Eliminado { get; set; }

    public int? Owner { get; set; }
}

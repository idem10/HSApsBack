using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class TurEquipoApuestum
{
    public int Id { get; set; }

    public int Owner { get; set; }

    public decimal Apuesta { get; set; }

    public int IdTorneo { get; set; }

    public int IdEquipo { get; set; }
}

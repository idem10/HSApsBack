using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class TurEquipo
{
    public int Id { get; set; }

    public string Equipo { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Flag { get; set; } = null!;
}

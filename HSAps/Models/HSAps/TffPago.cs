using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class TffPago
{
    public int Id { get; set; }

    public int IdInt { get; set; }

    public decimal Monto { get; set; }

    public string Periodo { get; set; } = null!;

    public DateTime FechaPago { get; set; }

    public string Observaciones { get; set; } = null!;

    public decimal? Adeudo { get; set; }

    public DateTime? FechaVencimiento { get; set; }
}

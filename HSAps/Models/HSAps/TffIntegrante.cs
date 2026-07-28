using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class TffIntegrante
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string Categoria { get; set; } = null!;

    public int Activo { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string? Imagen { get; set; }
}

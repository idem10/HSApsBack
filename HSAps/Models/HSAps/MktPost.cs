using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class MktPost
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Contenido { get; set; } = null!;

    public string? Imagen { get; set; }

    public string? VideoUrl { get; set; }

    public int Estatus { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IsActive { get; set; }

    public int Privacidad { get; set; }
}

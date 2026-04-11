using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class DmHorario
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public string? Hora { get; set; }

    public string? Dia { get; set; }

    public string? Materia { get; set; }

    public string? Edificio { get; set; }

    public string? Salon { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? Eliminar { get; set; }
}

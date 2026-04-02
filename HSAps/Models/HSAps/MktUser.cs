using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class MktUser
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public int IsActive { get; set; }

    public int Rol { get; set; }

    public string? Imagen { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? App { get; set; }
}

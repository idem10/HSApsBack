using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class InsUsuario
{
    public long UsuarioId { get; set; }

    public string? Nombre { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? FotoPerfil { get; set; }

    public string? Biografia { get; set; }

    public string? SitioWeb { get; set; }

    public bool? EsPrivado { get; set; }

    public DateTime? FechaRegistro { get; set; }
}

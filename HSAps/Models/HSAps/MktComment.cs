using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class MktComment
{
    public int Id { get; set; }

    public int PostId { get; set; }

    public int UserId { get; set; }

    public string Contenido { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }
}

using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class MktPostLike
{
    public int Id { get; set; }

    public int PostId { get; set; }

    public int UserId { get; set; }

    public DateTime? FechaCreacion { get; set; }
}

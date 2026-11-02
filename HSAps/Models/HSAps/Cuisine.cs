using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class Cuisine
{
    public int CuisineId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }
}

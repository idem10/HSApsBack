using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class PriceLevel
{
    public int PriceLevelId { get; set; }

    public string Name { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public int SortOrder { get; set; }
}

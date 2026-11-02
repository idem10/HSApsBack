using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class PlacePhoto
{
    public long PhotoId { get; set; }

    public long PlaceId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public bool IsMain { get; set; }

    public int SortOrder { get; set; }

    public DateTime CreatedAt { get; set; }
}

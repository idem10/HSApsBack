using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class Review
{
    public long ReviewId { get; set; }

    public long PlaceId { get; set; }

    public long UserId { get; set; }

    public byte Rating { get; set; }

    public string? Comment { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

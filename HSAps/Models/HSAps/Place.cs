using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class Place
{
    public long PlaceId { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public int? CuisineId { get; set; }

    public int? PriceLevelId { get; set; }

    public string? Emoji { get; set; }

    public string? Color { get; set; }

    public string? Description { get; set; }

    public decimal AverageRating { get; set; }

    public int ReviewCount { get; set; }

    public bool IsActive { get; set; }

    public bool IsVerified { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

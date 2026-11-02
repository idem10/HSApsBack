using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class PlaceLocation
{
    public long LocationId { get; set; }

    public long PlaceId { get; set; }

    public string? Address { get; set; }

    public string? Area { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime CreatedAt { get; set; }
}

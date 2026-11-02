using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class Favorite
{
    public long FavoriteId { get; set; }

    public long UserId { get; set; }

    public long PlaceId { get; set; }

    public DateTime CreatedAt { get; set; }
}

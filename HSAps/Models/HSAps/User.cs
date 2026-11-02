using System;
using System.Collections.Generic;

namespace HSAps.Models.HSAps;

public partial class User
{
    public long UserId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PasswordHash { get; set; }

    public string? ProfileImage { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }
}

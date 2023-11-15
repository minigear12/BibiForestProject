using System;
using System.Collections.Generic;

namespace BibiBusiness.Models;

public class Bibi
{
    public int BibiId { get; set; }

    public string OwnerId { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string BibiName { get; set; } = null!;

    public string? Food { get; set; }

    public string? Country { get; set; }

    public string? Forest { get; set; }

    public virtual Owner Owner { get; set; } = null!;
}

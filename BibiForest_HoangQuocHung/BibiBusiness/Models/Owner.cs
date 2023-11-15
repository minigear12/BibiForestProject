using System;
using System.Collections.Generic;

namespace BibiBusiness.Models;

public partial class Owner
{
    public string OwnerId { get; set; } = null!;

    public string OwnerName { get; set; } = null!;

    public virtual ICollection<Bibi> Bibis { get; set; } = new List<Bibi>();
}

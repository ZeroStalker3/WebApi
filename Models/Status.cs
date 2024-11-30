using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Status
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}

using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class TypeLack
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EventEmployee> EventEmployees { get; set; } = new List<EventEmployee>();
}

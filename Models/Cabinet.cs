using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Cabinet
{
    public int Id { get; set; }

    public string NumberCabinet { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}

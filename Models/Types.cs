﻿using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Types
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}

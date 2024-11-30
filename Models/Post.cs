﻿using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Post
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}

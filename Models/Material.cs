using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly ApprovalDate { get; set; }

    public DateOnly DateChange { get; set; }

    public int IdStatus { get; set; }

    public string Type { get; set; } = null!;

    public string Area { get; set; } = null!;

    public int IdEmployee { get; set; }

    public virtual Employee IdEmployeeNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;
}

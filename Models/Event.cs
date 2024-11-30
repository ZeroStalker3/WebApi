using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Event
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdType { get; set; }

    public int IdStatus { get; set; }

    public DateOnly Dataevent { get; set; }

    public int IdEmployee { get; set; }

    public string Description { get; set; } = null!;

    public virtual Employee IdEmployeeNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual Type IdTypeNavigation { get; set; } = null!;
}

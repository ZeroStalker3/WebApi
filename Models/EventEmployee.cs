using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class EventEmployee
{
    public int Id { get; set; }

    public DateOnly? StartDate { get; set; }

    public int? IdEmployee { get; set; }

    public int? IdTypeLack { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual Employee? IdEmployeeNavigation { get; set; }

    public virtual TypeLack? IdTypeLackNavigation { get; set; }
}

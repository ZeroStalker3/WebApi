using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? FirtsName { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? NumberPhone { get; set; }

    public string? Email { get; set; }

    public string? Birthday { get; set; }

    public int? IdDepartament { get; set; }

    public int? IdPost { get; set; }

    public int? IdCabinet { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Cabinet? IdCabinetNavigation { get; set; }

    public virtual DivisionsAndDdepartamentAndOrganization? IdDepartamentNavigation { get; set; }

    public virtual Post? IdPostNavigation { get; set; }

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}

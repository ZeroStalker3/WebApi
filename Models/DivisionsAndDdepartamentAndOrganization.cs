using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class DivisionsAndDdepartamentAndOrganization
{
    public int Id { get; set; }

    public int? IdDivision { get; set; }

    public int? IdOrganization { get; set; }

    public int? IdDepartament { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Departament? IdDepartamentNavigation { get; set; }

    public virtual Organization? IdOrganizationNavigation { get; set; }
}

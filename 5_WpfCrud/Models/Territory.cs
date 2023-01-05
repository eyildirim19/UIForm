using System;
using System.Collections.Generic;

namespace _5_WpfCrud.Models;

public partial class Territory
{
    public string TerritoryId { get; set; } = null!;

    public string TerritoryDescription { get; set; } = null!;

    public int RegionId { get; set; }

    public virtual ICollection<Kullanicilar> Kullanicilars { get; } = new List<Kullanicilar>();

    public virtual Region Region { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}

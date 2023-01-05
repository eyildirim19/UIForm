using System;
using System.Collections.Generic;

namespace _5_WpfCrud.Models;

public partial class ShippersLog
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime? CreDate { get; set; }
}

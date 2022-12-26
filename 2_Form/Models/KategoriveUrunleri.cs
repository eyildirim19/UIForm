using System;
using System.Collections.Generic;

namespace _2_Form.Models;

public partial class KategoriveUrunleri
{
    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }
}

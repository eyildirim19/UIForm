using System;
using System.Collections.Generic;

namespace _2_Form.Models;

public partial class UrunStokDurumu
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public string StokDurum { get; set; } = null!;
}

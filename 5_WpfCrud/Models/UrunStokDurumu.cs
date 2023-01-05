using System;
using System.Collections.Generic;

namespace _5_WpfCrud.Models;

public partial class UrunStokDurumu
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public string StokDurum { get; set; } = null!;
}

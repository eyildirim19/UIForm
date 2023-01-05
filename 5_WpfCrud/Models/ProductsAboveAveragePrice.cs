using System;
using System.Collections.Generic;

namespace _5_WpfCrud.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}

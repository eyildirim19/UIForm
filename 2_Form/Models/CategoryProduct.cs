using System;
using System.Collections.Generic;

namespace _2_Form.Models;

public partial class CategoryProduct
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public short? Stock { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category1? Category { get; set; }
}

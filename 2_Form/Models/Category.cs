using System;
using System.Collections.Generic;

namespace _2_Form.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();


    public override string ToString()
    {
        return CategoryName;
    }
}

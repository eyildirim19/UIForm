using System;
using System.Collections.Generic;

namespace _2_Form.Models;

public partial class Category1
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? CategoryDesc { get; set; }

    public DateTime? CreDate { get; set; }

    public virtual ICollection<CategoryProduct> CategoryProducts { get; } = new List<CategoryProduct>();
}

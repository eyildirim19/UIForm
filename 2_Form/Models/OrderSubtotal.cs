﻿using System;
using System.Collections.Generic;

namespace _2_Form.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}

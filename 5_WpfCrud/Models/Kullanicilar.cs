using System;
using System.Collections.Generic;

namespace _5_WpfCrud.Models;

public partial class Kullanicilar
{
    public int Id { get; set; }

    public string? Adi { get; set; }

    public string? SoyAdi { get; set; }

    public byte? Yas { get; set; }

    public decimal? Maas { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? CreDate { get; set; }

    public string? MemleketId { get; set; }

    public virtual Territory? Memleket { get; set; }
}

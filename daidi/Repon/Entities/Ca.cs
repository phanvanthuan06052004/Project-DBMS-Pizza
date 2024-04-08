using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class Ca
{
    public string MaCa { get; set; } = null!;

    public TimeOnly GioBatDau { get; set; }

    public TimeOnly GioKetThuc { get; set; }

    public virtual ICollection<ChiTietCaTruc> ChiTietCaTrucs { get; set; } = new List<ChiTietCaTruc>();
}

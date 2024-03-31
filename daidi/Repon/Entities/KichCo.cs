using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class KichCo
{
    public string MaKichCo { get; set; } = null!;

    public string TenKichCo { get; set; } = null!;

    public virtual ICollection<ChiTietKichCo> ChiTietKichCos { get; set; } = new List<ChiTietKichCo>();
}

using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class ChiTietKichCo
{
    public int? SoLuong { get; set; }

    public decimal? DonGia { get; set; }

    public string MaSp { get; set; } = null!;

    public string MaKichCo { get; set; } = null!;

    public virtual KichCo MaKichCoNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string TenKh { get; set; } = null!;

    public string? SoDt { get; set; }

    public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; } = new List<HoaDonBanHang>();
}

using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class ChiTietHd
{
    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public string MaHd { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public virtual HoaDonBanHang MaHdNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}

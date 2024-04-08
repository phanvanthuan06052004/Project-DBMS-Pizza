using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class ChiTietHd
{
    public int SoLuong { get; set; }

    public decimal TriGia { get; set; }

    public string MaKichCo { get; set; } = null!;

    public string MaHd { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public virtual HoaDonBanHang MaHdNavigation { get; set; } = null!;

    public virtual KichCo MaKichCoNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class ChiTietPn
{
    public int DonGia { get; set; }

    public int SoLuong { get; set; }

    public decimal TongTien { get; set; }

    public string MaPhieu { get; set; } = null!;

    public string MaNl { get; set; } = null!;

    public virtual NguyenLieu MaNlNavigation { get; set; } = null!;

    public virtual PhieuNhap MaPhieuNavigation { get; set; } = null!;
}

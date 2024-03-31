using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class PhieuNhap
{
    public string MaPhieu { get; set; } = null!;

    public DateOnly NgayNhap { get; set; }

    public decimal TriGiaDonNh { get; set; }

    public string MaNv { get; set; } = null!;

    public string MaNcc { get; set; } = null!;

    public virtual ICollection<ChiTietPn> ChiTietPns { get; set; } = new List<ChiTietPn>();

    public virtual NhaCungCap MaNccNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}

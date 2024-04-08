using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class HoaDonBanHang
{
    public string MaHd { get; set; } = null!;

    public DateTime NgayGioDat { get; set; }

    public string MaNv { get; set; } = null!;

    public string MaKh { get; set; } = null!;

    public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}

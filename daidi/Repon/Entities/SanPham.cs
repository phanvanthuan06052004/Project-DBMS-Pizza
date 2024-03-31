using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class SanPham
{
    public string MaSp { get; set; } = null!;

    public string TenSp { get; set; } = null!;

    public string MaLoaiSp { get; set; } = null!;

    public virtual ICollection<CheBien> CheBiens { get; set; } = new List<CheBien>();

    public virtual ICollection<ChiTietHd> ChiTietHds { get; set; } = new List<ChiTietHd>();

    public virtual ICollection<ChiTietKichCo> ChiTietKichCos { get; set; } = new List<ChiTietKichCo>();

    public virtual LoaiSanPham MaLoaiSpNavigation { get; set; } = null!;
}

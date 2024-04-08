using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class CheBien
{
    public int? LieuLuong { get; set; }

    public string? DonVi { get; set; }

    public string MaNl { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public virtual NguyenLieu MaNlNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}

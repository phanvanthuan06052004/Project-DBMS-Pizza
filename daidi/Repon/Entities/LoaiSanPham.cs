using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class LoaiSanPham
{
    public string MaLoaiSp { get; set; } = null!;

    public string TenLoaiSp { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}

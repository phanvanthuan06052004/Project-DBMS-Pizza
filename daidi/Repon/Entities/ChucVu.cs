using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class ChucVu
{
    public string MaChucVu { get; set; } = null!;

    public string TenChucVu { get; set; } = null!;

    public int Luong { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}

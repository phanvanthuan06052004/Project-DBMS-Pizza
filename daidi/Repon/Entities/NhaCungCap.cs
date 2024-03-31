using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class NhaCungCap
{
    public string MaNcc { get; set; } = null!;

    public string TenNcc { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string SoDt { get; set; } = null!;

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();

    public virtual ICollection<NguyenLieu> MaNls { get; set; } = new List<NguyenLieu>();
}

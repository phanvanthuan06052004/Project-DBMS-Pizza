using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class NguyenLieu
{
    public string MaNl { get; set; } = null!;

    public string TenNl { get; set; } = null!;

    public int SoLuong { get; set; }

    public string DonVi { get; set; } = null!;

    public virtual ICollection<CheBien> CheBiens { get; set; } = new List<CheBien>();

    public virtual ICollection<ChiTietPn> ChiTietPns { get; set; } = new List<ChiTietPn>();

    public virtual ICollection<NhaCungCap> MaNccs { get; set; } = new List<NhaCungCap>();
}

using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class ChiTietCaTruc
{
    public string MaNv { get; set; } = null!;

    public string MaCa { get; set; } = null!;

    public DateOnly Ngay { get; set; }

    public virtual Ca MaCaNavigation { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class TaiKhoan
{
    public int MaDangNhap { get; set; }

    public int MatKhau { get; set; }

    public string MaNv { get; set; } = null!;

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}

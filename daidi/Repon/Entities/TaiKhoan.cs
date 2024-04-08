using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class TaiKhoan
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string MaNv { get; set; } = null!;

    public int Role { get; set; }

    public virtual NhanVien MaNvNavigation { get; set; } = null!;
}

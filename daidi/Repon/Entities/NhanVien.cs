using System;
using System.Collections.Generic;

namespace Repon.Entities;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string HoNv { get; set; } = null!;

    public string TenLotNv { get; set; } = null!;

    public string TenNv { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public string SoDt { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string? Email { get; set; }

    public string Cccd { get; set; } = null!;

    public string MaChucVu { get; set; } = null!;

    public virtual ICollection<ChiTietCaTruc> ChiTietCaTrucs { get; set; } = new List<ChiTietCaTruc>();

    public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; } = new List<HoaDonBanHang>();

    public virtual ChucVu MaChucVuNavigation { get; set; } = null!;

    public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; } = new List<PhieuNhap>();

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}

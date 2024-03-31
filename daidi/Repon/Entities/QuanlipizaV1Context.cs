using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Repon.Entities;

public partial class QuanlipizaV1Context : DbContext
{
    public QuanlipizaV1Context()
    {
    }

    public QuanlipizaV1Context(DbContextOptions<QuanlipizaV1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ca> Cas { get; set; }

    public virtual DbSet<CheBien> CheBiens { get; set; }

    public virtual DbSet<ChiTietHd> ChiTietHds { get; set; }

    public virtual DbSet<ChiTietKichCo> ChiTietKichCos { get; set; }

    public virtual DbSet<ChiTietPn> ChiTietPns { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KichCo> KichCos { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<NguyenLieu> NguyenLieus { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-PTKCCTJC;Initial Catalog=quanlipizaV1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ca>(entity =>
        {
            entity.HasKey(e => e.MaCa).HasName("PK__Ca__27258E7B201400B7");

            entity.ToTable("Ca");

            entity.Property(e => e.MaCa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CheBien>(entity =>
        {
            entity.HasKey(e => new { e.MaNl, e.MaSp }).HasName("PK__CheBien__F55787BDFEBD560E");

            entity.ToTable("CheBien");

            entity.Property(e => e.MaNl)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNL");
            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");
            entity.Property(e => e.DonVi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.MaNlNavigation).WithMany(p => p.CheBiens)
                .HasForeignKey(d => d.MaNl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CheBien__MaNL__693CA210");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.CheBiens)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CheBien__MaSP__6A30C649");
        });

        modelBuilder.Entity<ChiTietHd>(entity =>
        {
            entity.HasKey(e => new { e.MaHd, e.MaSp }).HasName("PK__ChiTietH__F557F66113163C96");

            entity.ToTable("ChiTietHD");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaHD");
            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");
            entity.Property(e => e.DonGia).HasColumnType("money");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.ChiTietHds)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHD__MaHD__6477ECF3");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietHds)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHD__MaSP__656C112C");
        });

        modelBuilder.Entity<ChiTietKichCo>(entity =>
        {
            entity.HasKey(e => new { e.MaSp, e.MaKichCo }).HasName("PK__ChiTietK__4AC266C47DE134B9");

            entity.ToTable("ChiTietKichCo");

            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");
            entity.Property(e => e.MaKichCo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DonGia).HasColumnType("money");

            entity.HasOne(d => d.MaKichCoNavigation).WithMany(p => p.ChiTietKichCos)
                .HasForeignKey(d => d.MaKichCo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietKi__MaKic__72C60C4A");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietKichCos)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietKic__MaSP__71D1E811");
        });

        modelBuilder.Entity<ChiTietPn>(entity =>
        {
            entity.HasKey(e => new { e.MaPhieu, e.MaNl }).HasName("PK__ChiTietP__F412E2938625839C");

            entity.ToTable("ChiTietPN");

            entity.Property(e => e.MaPhieu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaNl)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNL");
            entity.Property(e => e.TongTien).HasColumnType("money");

            entity.HasOne(d => d.MaNlNavigation).WithMany(p => p.ChiTietPns)
                .HasForeignKey(d => d.MaNl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietPN__MaNL__60A75C0F");

            entity.HasOne(d => d.MaPhieuNavigation).WithMany(p => p.ChiTietPns)
                .HasForeignKey(d => d.MaPhieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietPN__MaPhi__5FB337D6");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.MaChucVu).HasName("PK__ChucVu__D4639533DA401B4D");

            entity.ToTable("ChucVu");

            entity.Property(e => e.MaChucVu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenChucVu).HasMaxLength(20);
        });

        modelBuilder.Entity<HoaDonBanHang>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDonBa__2725A6E0C429F315");

            entity.ToTable("HoaDonBanHang");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayGioDat).HasColumnType("datetime");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDonBanHangs)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonBanH__MaKH__5812160E");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDonBanHangs)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonBanH__MaNV__571DF1D5");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1EF28F4F30");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaKH");
            entity.Property(e => e.SoDt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoDT");
            entity.Property(e => e.TenKh)
                .HasMaxLength(30)
                .HasColumnName("TenKH");
        });

        modelBuilder.Entity<KichCo>(entity =>
        {
            entity.HasKey(e => e.MaKichCo).HasName("PK__KichCo__DE76ED8764859182");

            entity.ToTable("KichCo");

            entity.Property(e => e.MaKichCo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TenKichCo).HasMaxLength(30);
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.MaLoaiSp).HasName("PK__LoaiSanP__1224CA7CD4984B49");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.MaLoaiSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaLoaiSP");
            entity.Property(e => e.TenLoaiSp)
                .HasMaxLength(30)
                .HasColumnName("TenLoaiSP");
        });

        modelBuilder.Entity<NguyenLieu>(entity =>
        {
            entity.HasKey(e => e.MaNl).HasName("PK__NguyenLi__2725D73CB41C2DDD");

            entity.ToTable("NguyenLieu");

            entity.Property(e => e.MaNl)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNL");
            entity.Property(e => e.DonVi).HasMaxLength(20);
            entity.Property(e => e.TenNl)
                .HasMaxLength(30)
                .HasColumnName("TenNL");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNcc).HasName("PK__NhaCungC__3A185DEBE7450ED9");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNCC");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.SoDt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoDT");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(30)
                .HasColumnName("TenNCC");

            entity.HasMany(d => d.MaNls).WithMany(p => p.MaNccs)
                .UsingEntity<Dictionary<string, object>>(
                    "ChiTietCungCap",
                    r => r.HasOne<NguyenLieu>().WithMany()
                        .HasForeignKey("MaNl")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ChiTietCun__MaNL__48CFD27E"),
                    l => l.HasOne<NhaCungCap>().WithMany()
                        .HasForeignKey("MaNcc")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ChiTietCu__MaNCC__47DBAE45"),
                    j =>
                    {
                        j.HasKey("MaNcc", "MaNl").HasName("PK__ChiTietC__E86A00983A194F34");
                        j.ToTable("ChiTietCungCap");
                        j.IndexerProperty<string>("MaNcc")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("MaNCC");
                        j.IndexerProperty<string>("MaNl")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("MaNL");
                    });
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A9D969C5D");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNV");
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CCCD");
            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.HoNv)
                .HasMaxLength(10)
                .HasColumnName("HoNV");
            entity.Property(e => e.MaChucVu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SoDt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SoDT");
            entity.Property(e => e.TenLotNv)
                .HasMaxLength(20)
                .HasColumnName("TenLotNV");
            entity.Property(e => e.TenNv)
                .HasMaxLength(20)
                .HasColumnName("TenNV");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaChucVu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhanVien__MaChuc__4E88ABD4");

            entity.HasMany(d => d.MaCas).WithMany(p => p.MaNvs)
                .UsingEntity<Dictionary<string, object>>(
                    "ChiTietCaTruc",
                    r => r.HasOne<Ca>().WithMany()
                        .HasForeignKey("MaCa")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ChiTietCaT__MaCa__6EF57B66"),
                    l => l.HasOne<NhanVien>().WithMany()
                        .HasForeignKey("MaNv")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ChiTietCaT__MaNV__6E01572D"),
                    j =>
                    {
                        j.HasKey("MaNv", "MaCa").HasName("PK__ChiTietC__85578FED7281F8A5");
                        j.ToTable("ChiTietCaTruc");
                        j.IndexerProperty<string>("MaNv")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("MaNV");
                        j.IndexerProperty<string>("MaCa")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .IsFixedLength();
                    });
        });

        modelBuilder.Entity<PhieuNhap>(entity =>
        {
            entity.HasKey(e => e.MaPhieu).HasName("PK__PhieuNha__2660BFE08254F666");

            entity.ToTable("PhieuNhap");

            entity.Property(e => e.MaPhieu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MaNcc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNCC");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNV");
            entity.Property(e => e.TriGiaDonNh)
                .HasColumnType("money")
                .HasColumnName("TriGiaDonNH");

            entity.HasOne(d => d.MaNccNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaNcc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhieuNhap__MaNCC__5BE2A6F2");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.PhieuNhaps)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhieuNhap__MaNV__5AEE82B9");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp).HasName("PK__SanPham__2725081C3EEB8FDB");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSP");
            entity.Property(e => e.MaLoaiSp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaLoaiSP");
            entity.Property(e => e.TenSp)
                .HasMaxLength(30)
                .HasColumnName("TenSP");

            entity.HasOne(d => d.MaLoaiSpNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoaiSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__MaLoaiS__5441852A");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaDangNhap).HasName("PK__TaiKhoan__C869B8C09ED6B5B4");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MaDangNhap).ValueGeneratedNever();
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaNV");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaiKhoan__MaNV__5165187F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

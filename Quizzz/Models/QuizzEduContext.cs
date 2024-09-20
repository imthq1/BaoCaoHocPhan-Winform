using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Quizzz.Models;

public partial class QuizzEduContext : DbContext
{
    public QuizzEduContext()
    {
    }

    public QuizzEduContext(DbContextOptions<QuizzEduContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<CaThi> CaThis { get; set; }

    public virtual DbSet<CauHoi> CauHois { get; set; }

    public virtual DbSet<KetQua> KetQuas { get; set; }

    public virtual DbSet<MonThi> MonThis { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("jsconfig1.json").Build();
        optionsBuilder.UseSqlServer(config.GetConnectionString("QuizzEduDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.MaAdmin).HasName("PK__Admin__49341E380C179EA2");

            entity.ToTable("Admin");

            entity.HasIndex(e => e.TenDangNhap, "UQ__Admin__55F68FC027EB0D8C").IsUnique();

            entity.Property(e => e.MaAdmin).ValueGeneratedNever();
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CaThi>(entity =>
        {
            entity.HasKey(e => e.MaCaThi).HasName("PK__CaThi__642CCED6D0150697");

            entity.ToTable("CaThi");

            entity.Property(e => e.MaCaThi).ValueGeneratedNever();
            entity.Property(e => e.ThoiGian).HasColumnType("datetime");
        });

        modelBuilder.Entity<CauHoi>(entity =>
        {
            entity.HasKey(e => e.MaCauHoi).HasName("PK__CauHoi__1937D77BCA80BCAA");

            entity.ToTable("CauHoi");

            entity.Property(e => e.MaCauHoi).ValueGeneratedNever();
            entity.Property(e => e.DapAn).HasMaxLength(100);
            entity.Property(e => e.MaMonThi)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NoiDung).HasMaxLength(500);
            entity.Property(e => e.TenCauHoi).HasMaxLength(100);

            entity.HasOne(d => d.MaMonThiNavigation).WithMany(p => p.CauHois)
                .HasForeignKey(d => d.MaMonThi)
                .HasConstraintName("FK__CauHoi__MaMonThi__52593CB8");
        });

        modelBuilder.Entity<KetQua>(entity =>
        {
            entity.HasKey(e => e.MaKetQua).HasName("PK__KetQua__D5B3102AA0B09E0F");

            entity.ToTable("KetQua");

            entity.Property(e => e.MaKetQua).ValueGeneratedNever();
            entity.Property(e => e.MaMonThi)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.MaCaThiNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaCaThi)
                .HasConstraintName("FK__KetQua__MaCaThi__571DF1D5");

            entity.HasOne(d => d.MaMonThiNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaMonThi)
                .HasConstraintName("FK__KetQua__MaMonThi__5629CD9C");

            entity.HasOne(d => d.MaSinhVienNavigation).WithMany(p => p.KetQuas)
                .HasForeignKey(d => d.MaSinhVien)
                .HasConstraintName("FK__KetQua__MaSinhVi__5535A963");
        });

        modelBuilder.Entity<MonThi>(entity =>
        {
            entity.HasKey(e => e.MaMonThi).HasName("PK__MonThi__4027795E1D9D21BC");

            entity.ToTable("MonThi");

            entity.Property(e => e.MaMonThi)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenMonThi).HasMaxLength(100);
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSinhVien).HasName("PK__SinhVien__939AE7758BC55D32");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSinhVien).ValueGeneratedNever();
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.LopHoc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SQLProgramming.Models;

public partial class DbtestContext : DbContext
{
    public DbtestContext()
    {
    }

    public DbtestContext(DbContextOptions<DbtestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblLop> TblLops { get; set; }

    public virtual DbSet<TblSinhVien> TblSinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =(local); database = DBTest; uid=sa;pwd=123;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblLop>(entity =>
        {
            entity.HasKey(e => e.Malop);

            entity.ToTable("tbl_Lop");

            entity.Property(e => e.Malop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("malop");
            entity.Property(e => e.Namvaohoc).HasColumnName("namvaohoc");
            entity.Property(e => e.Nganhhoc)
                .HasMaxLength(50)
                .HasColumnName("nganhhoc");
            entity.Property(e => e.Slsv).HasColumnName("slsv");
            entity.Property(e => e.Tenlop)
                .HasMaxLength(50)
                .HasColumnName("tenlop");
        });

        modelBuilder.Entity<TblSinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv);

            entity.ToTable("tbl_SinhVien");

            entity.Property(e => e.MaSv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MaSV");
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.Malop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("malop");
            entity.Property(e => e.NgaySinh).HasColumnName("ngaySinh");
            entity.Property(e => e.Quequan)
                .HasMaxLength(200)
                .HasColumnName("quequan");
            entity.Property(e => e.SoCccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("soCCCD");
            entity.Property(e => e.SoDt)
                .HasMaxLength(20)
                .HasColumnName("SoDT");

            entity.HasOne(d => d.MalopNavigation).WithMany(p => p.TblSinhViens)
                .HasForeignKey(d => d.Malop)
                .HasConstraintName("FK_tbl_SinhVien_tbl_Lop");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

public partial class DbUrunlerContext : DbContext
{
    public DbUrunlerContext()
    {
    }

    public DbUrunlerContext(DbContextOptions<DbUrunlerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblBank> TblBanks { get; set; }

    public virtual DbSet<TblCompany> TblCompanies { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblDistrict> TblDistricts { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    public virtual DbSet<TblExpense> TblExpenses { get; set; }

    public virtual DbSet<TblInvoice> TblInvoices { get; set; }

    public virtual DbSet<TblInvoiceDetail> TblInvoiceDetails { get; set; }

    public virtual DbSet<TblNote> TblNotes { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProvince> TblProvinces { get; set; }

    public virtual DbSet<TblStock> TblStocks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SABBATH\\SQLEXPRESS;Database=DboCommericalAutomation;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblBank>(entity =>
        {
            entity.ToTable("Tbl_Bank");

            entity.Property(e => e.AccountNo).HasMaxLength(50);
            entity.Property(e => e.Authorized).HasMaxLength(50);
            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .HasColumnName("IBAN");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TblCompany>(entity =>
        {
            entity.ToTable("Tbl_Company");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.AuthorizedNameSurname).HasMaxLength(50);
            entity.Property(e => e.AuthorizedStatus).HasMaxLength(30);
            entity.Property(e => e.District).HasMaxLength(30);
            entity.Property(e => e.Fax).HasMaxLength(15);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(30);
            entity.Property(e => e.TaxOffice).HasMaxLength(30);
            entity.Property(e => e.TelNo1)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TelNo2)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TelNo3)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.ToTable("Tbl_Customer");

            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.District)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(25);
            entity.Property(e => e.Province)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Surname).HasMaxLength(30);
            entity.Property(e => e.TaxOffice).HasMaxLength(30);
            entity.Property(e => e.Tcno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TCNo");
            entity.Property(e => e.TelNo).HasMaxLength(15);
            entity.Property(e => e.TelNo2).HasMaxLength(15);
        });

        modelBuilder.Entity<TblDistrict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Ilce");

            entity.ToTable("Tbl_District");

            entity.Property(e => e.DistrictName)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.Province).WithMany(p => p.TblDistricts)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tbl_District_Tbl_Province");
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.ToTable("Tbl_Employee");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.District).HasMaxLength(30);
            entity.Property(e => e.Mail).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Province).HasMaxLength(30);
            entity.Property(e => e.Surname).HasMaxLength(30);
            entity.Property(e => e.Tcno)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TCNo");
            entity.Property(e => e.TelNo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblExpense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_Expe__3214EC278818A5F6");

            entity.ToTable("Tbl_Expenses");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Electricity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Internet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Month).HasMaxLength(20);
            entity.Property(e => e.NaturalGas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Other).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Salaries).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Water).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_Invo__3214EC07DF286197");

            entity.ToTable("Tbl_Invoice");

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Note).HasMaxLength(250);
            entity.Property(e => e.Serial).HasMaxLength(5);
            entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxNumber).HasMaxLength(20);
            entity.Property(e => e.TaxOffice).HasMaxLength(50);
        });

        modelBuilder.Entity<TblInvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tbl_Invo__3214EC0774E4BC10");

            entity.ToTable("Tbl_InvoiceDetail");

            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(10);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("VAT");
        });

        modelBuilder.Entity<TblNote>(entity =>
        {
            entity.ToTable("Tbl_Notes");

            entity.Property(e => e.Creator).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Description).HasMaxLength(450);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.ToTable("Tbl_Product");

            entity.Property(e => e.Brand).HasMaxLength(30);
            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Detail).HasMaxLength(450);
            entity.Property(e => e.Model).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblProvince>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sehir");

            entity.ToTable("Tbl_Province");

            entity.Property(e => e.ProvinceName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblStock>(entity =>
        {
            entity.ToTable("Tbl_Stock");

            entity.Property(e => e.StockType).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

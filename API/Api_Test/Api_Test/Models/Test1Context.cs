using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Api_Test.Models;

public partial class Test1Context : DbContext
{
    public Test1Context()
    {
    }

    public Test1Context(DbContextOptions<Test1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NumberOrder> NumberOrders { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-U89MQET\\MSSQL;Initial Catalog=Test_1;Persist Security Info=True;User ID=sa;Password=1;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NumberOrder>(entity =>
        {
            entity.HasKey(e => e.IdNumberOrder).HasName("PK__Number_O__51A915BE5B7133E2");

            entity.ToTable("Number_Order");

            entity.Property(e => e.IdNumberOrder).HasColumnName("ID_Number_Order");
            entity.Property(e => e.IdOrder).HasColumnName("ID_Order");
            entity.Property(e => e.IdProduct).HasColumnName("ID_Product");

            
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder).HasName("PK__Order__EC9FA95591DAE113");

            entity.ToTable("Order");

            entity.Property(e => e.IdOrder).HasColumnName("ID_Order");
            entity.Property(e => e.CartCost).HasColumnName("Cart Cost");
            entity.Property(e => e.DateOrder).HasColumnName("Date_Order");
            entity.Property(e => e.IdProduct).HasColumnName("ID_Product");
            entity.Property(e => e.IdUser).HasColumnName("ID_User");

          
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PK__Product__522DE496BFA965BB");

            entity.ToTable("Product");

            entity.Property(e => e.IdProduct).HasColumnName("ID_Product");
            entity.Property(e => e.IdStaff).HasColumnName("ID_Staff");
            entity.Property(e => e.NameProduct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Name_Product");

           
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.IdStaff).HasName("PK__Staff__922B8FE61C3D3D11");

            entity.Property(e => e.IdStaff).HasColumnName("ID_Staff");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Job_Title");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__User__ED4DE442DC2544CC");

            entity.ToTable("User");

            entity.HasIndex(e => new { e.IdUser, e.Login }, "U_User").IsUnique();

            entity.Property(e => e.IdUser).HasColumnName("ID_User");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

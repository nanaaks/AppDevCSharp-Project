using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectApp.Models.DataLayer;

public partial class IMSContext : DbContext
{
    public IMSContext()
    {
    }

    public IMSContext(DbContextOptions<IMSContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\App_Data\\IMSdb.mdf;Integrated security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__Items__727E83EB6F0BD2E1");

            entity.Property(e => e.ItemId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderNo).HasName("PK__Orders__C3907C74B92878E3");

            entity.Property(e => e.OrderNo).ValueGeneratedNever();

            entity.HasOne(d => d.Item).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Items");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CAD92E76F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

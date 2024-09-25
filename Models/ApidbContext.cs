using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPICRUD.Models;

public partial class ApidbContext : DbContext
{
    public ApidbContext()
    {
    }

    public ApidbContext(DbContextOptions<ApidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            //entity.HasNoKey();
            
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Age).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.FatherName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Standard).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StudentGender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.StudentName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

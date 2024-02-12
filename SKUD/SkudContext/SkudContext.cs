using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SKUD.Model;
using System.Configuration;

namespace SKUD.Context;

public partial class SkudContext : DbContext
{
    public SkudContext()
    {
    }

    public SkudContext(DbContextOptions<SkudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admission> Admissions { get; set; }

    public virtual DbSet<AdmissionTeacher> AdmissionTeachers { get; set; }

    public virtual DbSet<AllDataAdmission> AllDataAdmissions { get; set; }

    public virtual DbSet<AllDataTeacher> AllDataTeachers { get; set; }

    public virtual DbSet<DocumentName> DocumentNames { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admission>(entity =>
        {
            entity.ToTable("Admission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentsId).HasColumnName("DocumentsID");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Documents).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.DocumentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admission_DocumentName");

            entity.HasOne(d => d.State).WithMany(p => p.Admissions)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Admission_State");
        });

        modelBuilder.Entity<AdmissionTeacher>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.TeachersId).HasColumnName("TeachersID");

            entity.HasOne(d => d.State).WithMany(p => p.AdmissionTeachers)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdmissionTeachers_State");

            entity.HasOne(d => d.Teachers).WithMany(p => p.AdmissionTeachers)
                .HasForeignKey(d => d.TeachersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdmissionTeachers_Teachers");
        });

        modelBuilder.Entity<AllDataAdmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AlDataAdmission");

            entity.ToTable("AllDataAdmission");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocumentsId).HasColumnName("DocumentsID");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Documents).WithMany(p => p.AllDataAdmissions)
                .HasForeignKey(d => d.DocumentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AlDataAdmission_DocumentName");
        });

        modelBuilder.Entity<AllDataTeacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AllData");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.TeachersId).HasColumnName("TeachersID");

            entity.HasOne(d => d.State).WithMany(p => p.AllDataTeachers)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllData_State");

            entity.HasOne(d => d.Teachers).WithMany(p => p.AllDataTeachers)
                .HasForeignKey(d => d.TeachersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AllData_Teachers");
        });

        modelBuilder.Entity<DocumentName>(entity =>
        {
            entity.ToTable("DocumentName");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DocumentName1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DocumentName");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.ToTable("State");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.State1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("State");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

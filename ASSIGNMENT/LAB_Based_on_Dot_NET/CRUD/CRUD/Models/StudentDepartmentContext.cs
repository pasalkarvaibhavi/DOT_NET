using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models;

public partial class StudentDepartmentContext : DbContext
{
    public StudentDepartmentContext()
    {
    }

    public StudentDepartmentContext(DbContextOptions<StudentDepartmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MSCCS08;Initial Catalog=StudentDepartment;User ID=sa;Password=sql2024;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Cid);

            entity.ToTable("Course");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("cid");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.Credits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("credits");
            entity.Property(e => e.Did)
                .ValueGeneratedOnAdd()
                .HasColumnName("did");

            entity.HasOne(d => d.DidNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.Did)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Course_Department");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Did);

            entity.ToTable("Department");

            entity.Property(e => e.Did).HasColumnName("did");
            entity.Property(e => e.Dname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dname");
            entity.Property(e => e.Hod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hod");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid);

            entity.ToTable("Student");

            entity.Property(e => e.Sid).HasColumnName("sid");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Did).HasColumnName("did");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");

            entity.HasOne(d => d.DidNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.Did)
                .HasConstraintName("FK_Student_Department");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

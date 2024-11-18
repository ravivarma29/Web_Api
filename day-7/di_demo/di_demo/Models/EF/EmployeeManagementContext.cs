using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace di_demo.Models.EF;

public partial class EmployeeManagementContext : DbContext
{
    public EmployeeManagementContext()
    {
    }

    public EmployeeManagementContext(DbContextOptions<EmployeeManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DeptInfo> DeptInfos { get; set; }

    public virtual DbSet<EmpDetalilsView> EmpDetalilsViews { get; set; }

    public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    public virtual DbSet<Opening> Openings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\ProjectModels; database=employeeManagement; integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DeptInfo>(entity =>
        {
            entity.HasKey(e => e.DeptNo).HasName("PK__deptInfo__BE2D3F557DFAC0F2");

            entity.ToTable("deptInfo");

            entity.Property(e => e.DeptNo)
                .ValueGeneratedNever()
                .HasColumnName("deptNo");
            entity.Property(e => e.DeptCity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deptCity");
            entity.Property(e => e.DeptName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deptName");
        });

        modelBuilder.Entity<EmpDetalilsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("empDetalilsView");

            entity.Property(e => e.DepartmentNo).HasColumnName("departmentNo");
            entity.Property(e => e.DeptCity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deptCity");
            entity.Property(e => e.DeptName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("deptName");
            entity.Property(e => e.DeptNo).HasColumnName("deptNo");
            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empDesignation");
            entity.Property(e => e.EmpIsPermenant).HasColumnName("empIsPermenant");
            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empName");
            entity.Property(e => e.EmpNo).HasColumnName("empNo");
            entity.Property(e => e.EmpSalary).HasColumnName("empSalary");
        });

        modelBuilder.Entity<EmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.EmpNo).HasName("PK__employee__AFB33592AF0CFA1A");

            entity.ToTable("employeeInfo");

            entity.Property(e => e.EmpNo)
                .ValueGeneratedNever()
                .HasColumnName("empNo");
            entity.Property(e => e.DepartmentNo).HasColumnName("departmentNo");
            entity.Property(e => e.EmpDesignation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empDesignation");
            entity.Property(e => e.EmpIsPermenant).HasColumnName("empIsPermenant");
            entity.Property(e => e.EmpName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empName");
            entity.Property(e => e.EmpSalary).HasColumnName("empSalary");
        });

        modelBuilder.Entity<Opening>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PK__Openings__B07CF5AE3EEE2FBB");

            entity.Property(e => e.PositionId)
                .ValueGeneratedNever()
                .HasColumnName("positionId");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.IsPositionOpen).HasColumnName("isPositionOpen");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PositionDept).HasColumnName("positionDept");
            entity.Property(e => e.TotalPositions).HasColumnName("totalPositions");

            entity.HasOne(d => d.PositionDeptNavigation).WithMany(p => p.Openings)
                .HasForeignKey(d => d.PositionDept)
                .HasConstraintName("fk_dept");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

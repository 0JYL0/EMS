using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EMS.DL
{
    public partial class CompanyDBContext : DbContext
    {
        public CompanyDBContext()
        {
        }

        public CompanyDBContext(DbContextOptions<CompanyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeMapping> EmployeeMapping { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectMembers> ProjectMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=JYL\\SQLEXPRESS;Initial Catalog=CompanyDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_Employee")
                    .IsUnique();

                entity.HasIndex(e => e.EmployeeEmail)
                    .HasName("IX_Email")
                    .IsUnique();

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.EmployeeAddress)
                    .HasColumnName("employeeAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeEmail)
                    .IsRequired()
                    .HasColumnName("employeeEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeExperience)
                    .IsRequired()
                    .HasColumnName("employeeExperience")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeJoiningDate)
                    .HasColumnName("employeeJoiningDate")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasColumnName("employeeName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatus)
                    .HasColumnName("employeeStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Active')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeMapping>(entity =>
            {
                entity.HasIndex(e => new { e.ManagerId, e.EmployeeId })
                    .HasName("uk_map")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.ManagerId).HasColumnName("managerId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeMappingEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeMapping_Employee1");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.EmployeeMappingManager)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeMapping_Employee");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("date");

                entity.Property(e => e.ProjectDescription)
                    .IsRequired()
                    .HasColumnName("projectDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("projectName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTech).HasColumnName("projectTech");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<ProjectMembers>(entity =>
            {
                entity.HasIndex(e => new { e.ProjectId, e.EmployeeId })
                    .HasName("uks_map")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProjectMembers)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMembers_Employee");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectMembers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMembers_Project");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

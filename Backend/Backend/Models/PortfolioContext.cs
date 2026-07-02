using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models;

public partial class PortfolioContext : DbContext
{
    public PortfolioContext()
    {
    }

    public PortfolioContext(DbContextOptions<PortfolioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=tcp:SQL1004.site4now.net,1433;Initial Catalog=db_aca9e7_bimacad951;User Id=db_aca9e7_bimacad951_admin;Password=bimacad951;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(d => d.User).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasForeignKey(d => d.UserId)
                .HasConstraintName("Contact_User_FK");
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Education_PK");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.User).WithMany(p => p.Educations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Education_User_FK");
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Experience_PK");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.User).WithMany(p => p.Experiences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Experience_User_FK");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Project_PK");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.User).WithMany(p => p.Projects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Project_User_FK");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Skill_PK");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.User).WithMany(p => p.Skills)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Skill_User_FK");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_PK");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}

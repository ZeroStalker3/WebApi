using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models;

public partial class Yp3Context : DbContext
{
    public Yp3Context()
    {
    }

    public Yp3Context(DbContextOptions<Yp3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Cabinet> Cabinets { get; set; }
        
    public virtual DbSet<Calendar> Calendars { get; set; }

    public virtual DbSet<Departament> Departaments { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<DivisionsAndDdepartamentAndOrganization> DivisionsAndDdepartamentAndOrganizations { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventEmployee> EventEmployees { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Types> Types { get; set; }

    public virtual DbSet<TypeLack> TypeLacks { get; set; }

    public virtual DbSet<WorkingCalendar> WorkingCalendars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=ZEROYZ; Initial Catalog=YP3; TrustServerCertificate = true; Integrated Security = true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cabinet>(entity =>
        {
            entity.ToTable("Cabinet");

            entity.Property(e => e.NumberCabinet)
                .HasMaxLength(50)
                .HasColumnName("Number_cabinet");
        });

        modelBuilder.Entity<Calendar>(entity =>
        {
            entity.ToTable("Calendar");

            entity.Property(e => e.ExceptionDateExceptionDate).HasColumnName("ExceptionDate\r\nExceptionDate");
        });

        modelBuilder.Entity<Departament>(entity =>
        {
            entity.ToTable("Departament");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.ToTable("Division");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<DivisionsAndDdepartamentAndOrganization>(entity =>
        {
            entity.ToTable("DivisionsAndDdepartamentAndOrganization");

            entity.Property(e => e.IdDepartament).HasColumnName("Id_Departament");
            entity.Property(e => e.IdDivision).HasColumnName("Id_Division");
            entity.Property(e => e.IdOrganization).HasColumnName("Id_Organization");

            entity.HasOne(d => d.IdDepartamentNavigation).WithMany(p => p.DivisionsAndDdepartamentAndOrganizations)
                .HasForeignKey(d => d.IdDepartament)
                .HasConstraintName("FK_DivisionsAndDdepartamentAndOrganization_Departament");

            entity.HasOne(d => d.IdOrganizationNavigation).WithMany(p => p.DivisionsAndDdepartamentAndOrganizations)
                .HasForeignKey(d => d.IdOrganization)
                .HasConstraintName("FK_DivisionsAndDdepartamentAndOrganization_Organization");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.IdCabinet).HasColumnName("Id_Cabinet");
            entity.Property(e => e.IdDepartament).HasColumnName("Id_Departament");
            entity.Property(e => e.IdPost).HasColumnName("Id_Post");

            entity.HasOne(d => d.IdCabinetNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdCabinet)
                .HasConstraintName("FK_Employee_Cabinet");

            entity.HasOne(d => d.IdDepartamentNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdDepartament)
                .HasConstraintName("FK_Employee_DivisionsAndDdepartamentAndOrganization");

            entity.HasOne(d => d.IdPostNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdPost)
                .HasConstraintName("FK_Employee_Post");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event");

            entity.Property(e => e.IdEmployee)
                .HasMaxLength(50)
                .HasColumnName("Id_Employee");
            entity.Property(e => e.IdStatus).HasColumnName("Id_Status");
            entity.Property(e => e.IdType).HasColumnName("Id_Type");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_Employee");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_Status");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_Type");
        });

        modelBuilder.Entity<EventEmployee>(entity =>
        {
            entity.ToTable("EventEmployee");

            entity.Property(e => e.IdEmployee).HasMaxLength(50);

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.EventEmployees)
                .HasForeignKey(d => d.IdEmployee)
                .HasConstraintName("FK_EventEmployee_Employee");

            entity.HasOne(d => d.IdTypeLackNavigation).WithMany(p => p.EventEmployees)
                .HasForeignKey(d => d.IdTypeLack)
                .HasConstraintName("FK_EventEmployee_TypeLack");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.ToTable("Material");

            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.IdEmployee)
                .HasMaxLength(50)
                .HasColumnName("Id_Employee");
            entity.Property(e => e.IdStatus).HasColumnName("Id_Status");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.IdEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Material_Employee");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Material_Status");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.ToTable("Organization");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.ToTable("Post");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Types>(entity =>
        {
            entity.ToTable("Types");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeLack>(entity =>
        {
            entity.ToTable("TypeLack");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkingCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("WorkingCalendar_pk");

            entity.ToTable("WorkingCalendar");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("Идентификатор строки");
            entity.Property(e => e.ExceptionDate).HasComment("День-исключение");
            entity.Property(e => e.IsWorkingDay).HasComment("0 - будний день, но законодательно принят выходным");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

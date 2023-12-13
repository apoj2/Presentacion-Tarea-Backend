using System;
using System.Collections.Generic;
using Api.Tareas.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Api.Tareas.Persistencia
{
    public partial class TaskContext : DbContext
    {

        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nota> Notas { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IIR56KK;Database=Task;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nota>(entity =>
            {
                entity.ToTable("notas");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(4000)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaActivacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_activacion");

                entity.Property(e => e.FechaInactivacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inactivacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.Nota)
                    .HasForeignKey(d => d.Idusuario)
                    .HasConstraintName("FK__notas__idusuario__398D8EEE");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(50)
                    .HasColumnName("apellido1");

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(50)
                    .HasColumnName("apellido2");

                entity.Property(e => e.Apodo)
                    .HasMaxLength(50)
                    .HasColumnName("apodo");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(100)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaActivacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_activacion");

                entity.Property(e => e.FechaInactivacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_inactivacion");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_modificacion");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(50)
                    .HasColumnName("nombre1");

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(50)
                    .HasColumnName("nombre2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

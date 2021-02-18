using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tutorias.Models
{
    public partial class tutoriasContext : DbContext
    {
        public tutoriasContext()
        {
        }

        public tutoriasContext(DbContextOptions<tutoriasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Alumnosmateria> Alumnosmateria { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Maestro> Maestro { get; set; }
        public virtual DbSet<Maestrosmateria> Maestrosmateria { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Semestre> Semestre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost; user id=root; password=root; database=tutorias;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.NumeroControl);

                entity.ToTable("alumno");

                entity.HasIndex(e => e.IdCarrera)
                    .HasName("fkAlumnoCarrera");

                entity.HasIndex(e => e.IdRol)
                    .HasName("fkAlumnosRoles");

                entity.HasIndex(e => e.IdSemestre)
                    .HasName("fkAlumnoSemestre");

                entity.Property(e => e.NumeroControl).HasColumnType("varchar(8)");

                entity.Property(e => e.Activo).HasColumnType("bit(1)");

                entity.Property(e => e.ApMaterno)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ApPaterno)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IdCarrera).HasColumnType("int(11)");

                entity.Property(e => e.IdRol).HasColumnType("int(11)");

                entity.Property(e => e.IdSemestre).HasColumnType("int(11)");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.IdCarrera)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkAlumnoCarrera");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkAlumnosRoles");

                entity.HasOne(d => d.IdSemestreNavigation)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.IdSemestre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkAlumnoSemestre");
            });

            modelBuilder.Entity<Alumnosmateria>(entity =>
            {
                entity.ToTable("alumnosmateria");

                entity.HasIndex(e => e.IdAlumno)
                    .HasName("fkAlumnoMateria");

                entity.HasIndex(e => e.IdMateria)
                    .HasName("fkMateriaAlumno");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdAlumno)
                    .IsRequired()
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.IdMateria)
                    .IsRequired()
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.Alumnosmateria)
                    .HasForeignKey(d => d.IdAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkAlumnoMateria");

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.Alumnosmateria)
                    .HasForeignKey(d => d.IdMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkMateriaAlumno");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.ToTable("carrera");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Carrera1)
                    .IsRequired()
                    .HasColumnName("Carrera")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Maestro>(entity =>
            {
                entity.HasKey(e => e.NumeroControl);

                entity.ToTable("maestro");

                entity.HasIndex(e => e.IdRol)
                    .HasName("fkMaestrosRoles");

                entity.Property(e => e.NumeroControl).HasColumnType("varchar(4)");

                entity.Property(e => e.Activo).HasColumnType("bit(1)");

                entity.Property(e => e.ApMaterno)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ApPaterno)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IdRol).HasColumnType("int(11)");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Maestro)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkMaestrosRoles");
            });

            modelBuilder.Entity<Maestrosmateria>(entity =>
            {
                entity.ToTable("maestrosmateria");

                entity.HasIndex(e => e.IdMaestro)
                    .HasName("fkMaestroMateria");

                entity.HasIndex(e => e.IdMateria)
                    .HasName("fkMateriaMestro");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdMaestro)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.IdMateria)
                    .IsRequired()
                    .HasColumnType("varchar(8)");

                entity.HasOne(d => d.IdMaestroNavigation)
                    .WithMany(p => p.Maestrosmateria)
                    .HasForeignKey(d => d.IdMaestro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkMaestroMateria");

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.Maestrosmateria)
                    .HasForeignKey(d => d.IdMateria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkMateriaMestro");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("materia");

                entity.HasIndex(e => e.IdSemestre)
                    .HasName("fkMateriaSemestre");

                entity.Property(e => e.Clave).HasColumnType("varchar(8)");

                entity.Property(e => e.Activo).HasColumnType("bit(1)");

                entity.Property(e => e.IdSemestre).HasColumnType("int(11)");

                entity.Property(e => e.Materia1)
                    .IsRequired()
                    .HasColumnName("Materia")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.IdSemestreNavigation)
                    .WithMany(p => p.Materia)
                    .HasForeignKey(d => d.IdSemestre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkMateriaSemestre");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasColumnType("varchar(40)");
            });

            modelBuilder.Entity<Semestre>(entity =>
            {
                entity.ToTable("semestre");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.NoSem)
                    .HasColumnName("No_sem")
                    .HasColumnType("int(11)");
            });
        }
    }
}

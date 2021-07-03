using ApiKalumNotas.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiKalumNotas.DbContexts
{
    public class KalumNotasDBContext : DbContext
    {
        public DbSet<Clase> Clases {get;set;}
        public DbSet<Alumno> Alumnos {get;set;}
        public DbSet<AsignacionAlumno> AsignacionesAlumnos {get;set;}
        
        public KalumNotasDBContext(DbContextOptions<KalumNotasDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .ToTable("Alumnos")  .HasKey(c => new {c.Carne});
            modelBuilder.Entity<Salon>()
                .ToTable("Salones").HasKey(s => new {s.SalonId});
            modelBuilder.Entity<Horario>()
                .ToTable("Horarios").HasKey(h => new {h.HorarioId});
            modelBuilder.Entity<Instructor>()
                .ToTable("Instructores").HasKey(i => new {i.InstructorId});
            modelBuilder.Entity<CarreraTecnica>()
                .ToTable("CarrerasTecnicas").HasKey(c => new {c.CarreraId});
            modelBuilder.Entity<Clase>()
                .ToTable("Clases").HasKey(c => new {c.ClaseId});
            modelBuilder.Entity<Clase>()
                .HasOne<CarreraTecnica>(c => c.CarreraTecnica)
                .WithMany(ct => ct.Clases)
                .HasForeignKey(c => c.CarreraId);
            modelBuilder.Entity<AsignacionAlumno>()
                .ToTable("AsignacionesAlumnos")
                .HasKey(aa => aa.AsignacionId);
            modelBuilder.Entity<AsignacionAlumno>()
                .HasOne<Alumno>(aa => aa.Alumno)
                .WithMany(a => a.Asignaciones)
                .HasForeignKey(aa => aa.Carne);
        }
        
    }
}
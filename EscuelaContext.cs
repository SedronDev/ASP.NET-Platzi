using ASP_Platzi.Models;
using Microsoft.EntityFrameworkCore;

public class EscuelaContext : DbContext
{
    public DbSet<Escuela>? Escuelas {get;set;}
    public DbSet<Asignatura>? Asignaturas {get;set;}
    public DbSet<Alumno>? Alumnos {get;set;}
    public DbSet<Curso>? Cursos {get;set;}
    public DbSet<AlumnoEscuela>? AlumnoEscuelas {get;set;}

    public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        modelBuilder.Entity<Escuela>(escuela => 
        {
            escuela.ToTable("Escuela");
            escuela.HasKey(p => p.UniqueId);
            escuela.Property(p => p.Nombre);
            escuela.Property(p => p.AñoDeCreación);
            escuela.Property(p => p.Pais);
            escuela.Property(p => p.Dirección);
            escuela.Property(p => p.TipoEscuela);
            escuela.HasMany(p => p.Cursos).WithOne(p => p.escuela).HasForeignKey(p => p.UniqueId);
        });

        modelBuilder.Entity<AlumnoEscuela>(alumnoEscuela => {
            alumnoEscuela.ToTable("AlumnoEscuela");
            alumnoEscuela.HasKey(p => new { p.AlumnoId, p.EscuelaId});
            alumnoEscuela.HasOne(p => p.Alumno).WithMany(p => p.AlumnoEscuelas).HasForeignKey(p => p.AlumnoId);
            alumnoEscuela.HasOne(p => p.Escuela).WithMany(p => p.AlumnoEscuelas).HasForeignKey(p => p.EscuelaId);
        });

        modelBuilder.Entity<Alumno>(alumno => 
        {
            alumno.ToTable("Alumno");
            alumno.HasKey(p => p.UniqueId);
            alumno.Property(p => p.Nombre);
        }
        );

        modelBuilder.Entity<Curso>(curso => {
            curso.ToTable("Curso");
            curso.HasKey(p => p.UniqueId);
            curso.Property(p => p.Nombre);
            curso.HasOne(p => p.escuela).WithMany(p => p.Cursos).HasForeignKey(p => p.escuelaId);
        });

        modelBuilder.Entity<Asignatura>(asignatura => {
            asignatura.ToTable("Asignatura");
            asignatura.HasKey(p => p.UniqueId);
            asignatura.Property(p => p.Nombre);
        });
    }
}
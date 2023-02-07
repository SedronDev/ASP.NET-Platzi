
namespace ASP_Platzi.Models
{
    public class Escuela : ObjetoEscuelaBase
    {
        public int AñoDeCreación { get; set; }

        public string? Pais { get; set; }
        public string? Dirección { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; } = new List<Curso>();
        public ICollection<AlumnoEscuela>? AlumnoEscuelas { get;set; }
    }
}

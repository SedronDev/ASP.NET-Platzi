
namespace ASP_Platzi.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Curso> Cursos {get;set;} = new List<Curso>();
        public ICollection<AlumnoEscuela>? AlumnoEscuelas {get;set;}
    }
}
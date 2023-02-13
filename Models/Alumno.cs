
namespace ASP_Platzi.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public ICollection<AlumnoEscuela>? AlumnoEscuelas {get;set;}
    }
}
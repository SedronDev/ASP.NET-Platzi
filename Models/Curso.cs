namespace ASP_Platzi.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public string? escuelaId { get;set; }
        public Escuela? escuela { get;set; }
        public List<Asignatura> Asignaturas{ get;set; } = new List<Asignatura>();
    }
}
namespace ASP_Platzi.Models
{
    public class AlumnoEscuela
    {
        public string? AlumnoId { get;set; }
        public Alumno? Alumno { get;set; }
        public string? EscuelaId { get;set; }
        public Escuela? Escuela { get;set; }
    }
}
namespace ASP_Platzi;
using ASP_Platzi.Models;

public class AlumnoService: IAlumnoService
{
    EscuelaContext dbContext;
    public AlumnoService(EscuelaContext db)
    {
        dbContext = db;
    }

    public IEnumerable<Alumno> Get()
    {
        return dbContext.Alumnos;
    }
    public async Task Save(Alumno alumno)
    {
        dbContext.Add(alumno);
        await dbContext.SaveChangesAsync();
    }

    public async Task Update(string id, Alumno alumno)
    {
        Alumno currentAlumno = dbContext.Alumnos.Find(id);
        if (currentAlumno != null)
        {
            currentAlumno.Nombre = alumno.Nombre;
            currentAlumno.Cursos = alumno.Cursos;
            currentAlumno.AlumnoEscuelas = alumno.AlumnoEscuelas;

            await dbContext.SaveChangesAsync();
        }
    }
    public async Task Delete(string id)
    {
        Alumno currentAlumno = dbContext.Alumnos.Find(id);
        if (currentAlumno != null)
        {
            dbContext.Alumnos.Remove(currentAlumno);
            
            await dbContext.SaveChangesAsync();
        }
    }
}

public interface IAlumnoService 
{
    IEnumerable<Alumno> Get();
    Task Save(Alumno alumno);
    Task Update(string id, Alumno alumno);
    Task Delete(string id);
}
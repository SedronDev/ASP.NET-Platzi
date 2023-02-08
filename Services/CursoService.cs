namespace ASP_Platzi;
using ASP_Platzi.Models;

public class CursoService: ICursoService
{
    EscuelaContext dbContext;
    public CursoService(EscuelaContext db)
    {
        dbContext = db;
    }

    public IEnumerable<Curso> Get()
    {
        return dbContext.Cursos;
    }
    public async Task Save(Curso curso)
    {
        dbContext.Add(curso);
        await dbContext.SaveChangesAsync();
    }

    public async Task Update(string id, Curso curso)
    {
        Curso currentCurso = dbContext.Cursos.Find(id);
        if (currentCurso != null)
        {
            currentCurso.Nombre = curso.Nombre;
            currentCurso.escuelaId = curso.escuelaId;
            currentCurso.escuela = curso.escuela;
            currentCurso.Asignaturas = curso.Asignaturas;

            await dbContext.SaveChangesAsync();
        }
    }
    public async Task Delete(string id)
    {
        Curso currentCurso = dbContext.Cursos.Find(id);
        if (currentCurso != null)
        {
            dbContext.Cursos.Remove(currentCurso);
            
            await dbContext.SaveChangesAsync();
        }
    }
}

public interface ICursoService
{
    IEnumerable<Curso> Get();
    Task Save(Curso curso);
    Task Update(string id, Curso curso);
    Task Delete(string id);
}
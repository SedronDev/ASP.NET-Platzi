namespace ASP_Platzi;
using ASP_Platzi.Models;

public class EscuelaService: IEscuelaService
{
    EscuelaContext dbContext;
    public EscuelaService(EscuelaContext db)
    {
        dbContext = db;
    }

    public IEnumerable<Escuela> Get()
    {
        return dbContext.Escuelas;
    }
    public async Task Save(Escuela escuela)
    {
        dbContext.Add(escuela);
        await dbContext.SaveChangesAsync();
    }

    public async Task Update(string id, Escuela escuela)
    {
        Escuela currentEscuela = dbContext.Escuelas.Find(id);
        if (currentEscuela != null)
        {
            currentEscuela.Nombre = escuela.Nombre;
            currentEscuela.AñoDeCreación = escuela.AñoDeCreación;
            currentEscuela.Pais = escuela.Pais;
            currentEscuela.Dirección = escuela.Dirección;
            currentEscuela.TipoEscuela = escuela.TipoEscuela;
            currentEscuela.Cursos = escuela.Cursos;
            currentEscuela.AlumnoEscuelas = escuela.AlumnoEscuelas;

            await dbContext.SaveChangesAsync();
        }
    }
    public async Task Delete(string id)
    {
        Escuela currentEscuela = dbContext.Escuelas.Find(id);
        if (currentEscuela != null)
        {
            dbContext.Escuelas.Remove(currentEscuela);
            
            await dbContext.SaveChangesAsync();
        }
    }
}

public interface IEscuelaService 
{
    IEnumerable<Escuela> Get();
    Task Save(Escuela escuela);
    Task Update(string id, Escuela escuela);
    Task Delete(string id);
}
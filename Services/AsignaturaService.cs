namespace ASP_Platzi;
using ASP_Platzi.Models;

public class AsignaturaService: IAsignaturaService
{
    EscuelaContext dbContext;
    public AsignaturaService(EscuelaContext db)
    {
        dbContext = db;
    }

    public IEnumerable<Asignatura> Get()
    {
        return dbContext.Asignaturas;
    }
    public async Task Save(Asignatura asignatura)
    {
        dbContext.Add(asignatura);
        await dbContext.SaveChangesAsync();
    }

    public async Task Update(string id, Asignatura asignatura)
    {
        Asignatura currentAsignatura = dbContext.Asignaturas.Find(id);
        if (currentAsignatura != null)
        {
            currentAsignatura.Nombre = asignatura.Nombre;

            await dbContext.SaveChangesAsync();
        }
    }
    public async Task Delete(string id)
    {
        Asignatura currentAsignatura = dbContext.Asignaturas.Find(id);
        if (currentAsignatura != null)
        {
            dbContext.Asignaturas.Remove(currentAsignatura);
            
            await dbContext.SaveChangesAsync();
        }
    }
}

public interface IAsignaturaService
{
    IEnumerable<Asignatura> Get();
    Task Save(Asignatura asignatura);
    Task Update(string id, Asignatura asignatura);
    Task Delete(string id);
}
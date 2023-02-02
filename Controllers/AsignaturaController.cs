using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
namespace ASP_Platzi.Controllers;

public class AsignaturaController: Controller
{
    public IActionResult Index()
    {
        Asignatura asignatura = new Asignatura{
            Nombre = "Programacion"
        };
        Asignatura asignatura2 = new Asignatura{
            Nombre = "Matematicas"
        };
        Asignatura asignatura3 = new Asignatura{
            Nombre = "Pump"
        };
        List<Asignatura> asignaturas = new List<Asignatura>() {asignatura, asignatura2, asignatura3};
        return View(asignaturas);
    }
}
using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class AlumnoController: Controller
{
    IAlumnoService alumnoService;

    public AlumnoController(IAlumnoService service)
    {
        alumnoService = service;
    }

    public IActionResult Index()
    {
        /*var conEscuela = new Alumno() { 
            UniqueId = "212537a1-c987-4be5-af83-cc8fb2af9238", 
            Nombre = "Sedron Conese",
            AlumnoEscuelas = 
        };
        alumnoService.Update("212537a1-c987-4be5-af83-cc8fb2af9238", conEscuela);*/
        return View();
    }
}
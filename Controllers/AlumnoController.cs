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

        return View();
        /*var escuela = dbContext.Escuelas?.FirstOrDefault();

        ViewBag.cosaDinamica = "Una string";
        return View(escuela);*/
    }
}
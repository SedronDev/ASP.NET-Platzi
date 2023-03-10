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
        List<Alumno> Alumnos = alumnoService.Get().ToList();
        return View(Alumnos);
    }

    public IActionResult Create()
    {
        return View();
    }
}
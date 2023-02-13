using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class CursoController: Controller
{
    ICursoService cursoService;

    public CursoController(ICursoService service)
    {
        cursoService = service;
    }

    public IActionResult Index()
    {
        List<Curso> Cursos = cursoService.Get().ToList();
        return View(Cursos);
    }

    public IActionResult Create()
    {

        return View();
    }
}
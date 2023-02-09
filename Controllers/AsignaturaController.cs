using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
namespace ASP_Platzi.Controllers;

public class AsignaturaController: Controller
{
    IAsignaturaService asignaturaService;

    public AsignaturaController(IAsignaturaService service)
    {
        asignaturaService = service;
    }
    public IActionResult Index()
    {
        var asignaturas = asignaturaService.Get().ToList();
        return View(asignaturas);
    }
    public IActionResult Create()
    {
        return View();
    }
}
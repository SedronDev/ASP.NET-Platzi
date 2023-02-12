using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class EscuelaController: Controller
{
    IEscuelaService escuelaService;

    public EscuelaController(IEscuelaService service)
    {
        escuelaService = service;
    }

    public IActionResult Index()
    {
        List<Escuela> Escuelas = escuelaService.Get().ToList();
        return View(Escuelas);
    }

    public IActionResult Create()
    {

        return View();
    }
}
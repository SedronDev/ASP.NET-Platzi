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
        var conNombre = new Escuela(){
            Nombre = "SedEscuela",
            AñoDeCreación = 1996,
            Pais = "Perú",
            Dirección = "Avenida Garzón 1895",
            TipoEscuela = TiposEscuela.Secundaria
        };
        escuelaService.Update("ddfc11e3-bf48-456a-9960-e30f613023ce", conNombre);
        return View();
    }
}
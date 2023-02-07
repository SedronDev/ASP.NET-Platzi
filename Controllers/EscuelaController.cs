using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class EscuelaController: Controller
{
    private EscuelaContext _context;

    public IActionResult Index()
    {
        var escuela = _context.Escuelas.FirstOrDefault();

        ViewBag.cosaDinamica = "Una string";
        return View(escuela);
    }

    public EscuelaController(EscuelaContext context)
    {
        _context = context;
    }
}
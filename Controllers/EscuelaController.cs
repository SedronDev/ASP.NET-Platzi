using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Platzi.Controllers;

public class EscuelaController: Controller
{
    EscuelaContext dbContext;

    public EscuelaController(EscuelaContext db)
    {
        dbContext = db;
    }

    public IActionResult Index()
    {
        return View();
        /*var escuela = dbContext.Escuelas?.FirstOrDefault();

        ViewBag.cosaDinamica = "Una string";
        return View(escuela);*/
    }
}
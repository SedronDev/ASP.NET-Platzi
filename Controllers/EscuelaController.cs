using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
namespace ASP_Platzi.Controllers;

public class EscuelaController: Controller
{
    public IActionResult Index()
    {
        Escuela escuela = new Escuela();
        escuela.AñoFundacion = 2005;
        escuela.EscuelaId = Guid.NewGuid().ToString();
        escuela.Nombre = "Platzi School";
        return View(escuela);
    }
}
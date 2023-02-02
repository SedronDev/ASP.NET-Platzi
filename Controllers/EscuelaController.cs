using Microsoft.AspNetCore.Mvc;
using ASP_Platzi.Models;
namespace ASP_Platzi.Controllers;

public class EscuelaController: Controller
{
    public IActionResult Index()
    {
        Escuela escuela = new Escuela();
        escuela.AñoDeCreación = 2005;
        escuela.Nombre = "Platzi School";
        escuela.TipoEscuela = TiposEscuela.Secundaria;
        escuela.Ciudad = "Lima";
        escuela.Pais = "Peru";
        escuela.Dirección = "Psj Caracas 2518, Lince";

        ViewBag.cosaDinamica = "Una string";
        return View(escuela);
    }
}
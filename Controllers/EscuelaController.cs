using Microsoft.AspNetCore.Mvc;

namespace ASP_Platzi.Controllers;

public class EscuelaController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
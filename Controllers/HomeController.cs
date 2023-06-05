using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult tutorial()
    {

        return View();
    }

    public IActionResult Comenzar()
    {
        int numSala = Escape.getEstadoJuego();
        return View("sala" + numSala);
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        return View();
    }
}

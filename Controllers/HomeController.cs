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
        
if(sala!=Escape.getEstadoJuego()){
return View("sala"+Escape.getEstadoJuego());
}else if(!Escape.ResolverSala(sala, clave)){
    ViewBag.Error="El codigo no es correcto, vuelva a intentar";
return View("sala"+Escape.getEstadoJuego());
}else if(Escape.ResolverSala(sala, clave) && Escape.getEstadoJuego()==4){
return View();
}else{
    return View();
}






        return View();
    }
    
}


using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5SalaDeEscape.Models;

namespace TP5SalaDeEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Comenzar()
    {
        Escape.InicializarJuego();
        int estadoJuego = Escape.GetEstadoJuego();
        Console.WriteLine(estadoJuego);
        return View("habitacion"+ estadoJuego);
    }
    
    [HttpPost] public IActionResult habitacionX(int sala, string clave, int vidas)
    {
          int estadoJuego = Escape.GetEstadoJuego();
            if (sala == estadoJuego)
            {
                bool sino= Escape.ResolverSala(sala,clave);
                ViewBag.MensajeError = "";
                if(sino==false)
                {
                    ViewBag.MensajeError = "Respuesta incorrecta.";
                }
            }

            if(Escape.GetEstadoJuego()>4)
            {
                return View("victoria");
            } 
            else
            {
            return View("habitacion" + Escape.GetEstadoJuego());
            }
    }

    public IActionResult victoria()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

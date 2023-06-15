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
        int estadoJuego = Escape.GetEstadoJuego();
        string Sala = "Habitacion : " + estadoJuego;
        return View(Sala);
    }
    
    public IActionResult habitacionX(int sala, string clave)
    {
          int estadoJuego = Escape.GetEstadoJuego();

            if (sala != estadoJuego)
            {
                string salaAResolver = "Habitacion : " + estadoJuego;
                return View(salaAResolver);
            }

            if (Escape.ResolverSala(sala, clave))
            {
                estadoJuego = Escape.GetEstadoJuego();

                if (estadoJuego > 4)
                {
                    return View("Felicidades, has completado la sala de escape");
                }

                string siguienteSala = "Habitacion : " + estadoJuego;
                return View(siguienteSala);
            }

            ViewBag.Error = "Respuesta incorrecta.";
            return View("Habitacion : " + sala);
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

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Ahorcado.Models;

namespace TP04_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Partida.InicializarPartida();
        return View();
    }
     public IActionResult Jugar()
    {
        return View("Juego");
    }
    public IActionResult ahorcadoChar(char charArriesgado)
    {
        Partida.sumarIntento();
        string view = Partida.charAhorcado(charArriesgado);
        return View(view);
    }
    public IActionResult ahorcadoString(string stringArriesgado)
    {
        Partida.sumarIntento();
        string view = Partida.stringAhorcado(stringArriesgado);
        return View(view);
    }
}

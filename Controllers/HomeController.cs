using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Ahorcado.Models;

namespace TP04_Ahorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    int contadorLetrasAcertadas = 0;
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
    public IActionResult Ahorcado(char charArriesgado, string stringArriesgado)
    {
        string view = "Juego";
        Partida.sumarIntento();
        if(stringArriesgado == null)
        {
            bool existe = false;
            foreach(char char1 in Partida.letrasArriesga)
            {
                if(char1 == charArriesgado)
                {
                    existe = true;
                }
            }
            if(existe == false)
            {
                Partida.letrasArriesga.Add(charArriesgado);
                foreach(char charPalabra in Partida.palabra)
                {
                    if(charArriesgado == charPalabra)
                    {
                    contadorLetrasAcertadas++;
                    }
                }
            }
        }else
        {
            if(stringArriesgado ==  Partida.palabraReal)
            {
                view = "Ganar";
            }else
            {
                view = "Perder";
            }
        }
        return View(view);
    }
}

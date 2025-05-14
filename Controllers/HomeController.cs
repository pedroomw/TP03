using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
  
    public IActionResult Index()
    {
        Disqueria.InicializarDisqueria();
        ViewBag.Discos = Disqueria.Discos;
        return View();
    }

  
    public IActionResult DiscoInfo(string nombre)
{
    if (string.IsNullOrEmpty(nombre))
    {
        ViewBag.ErrorMessage = "El parámetro 'nombre' no puede ser nulo o vacío.";
        return View("Error");
    }

    ViewData["nombre"] = nombre;
    if (Disqueria.Discos.ContainsKey(nombre))
    {
        Disco disco = Disqueria.Discos[nombre];
        ViewBag.Canciones = disco.canciones;
        ViewBag.Artista = disco.artista;
        ViewBag.Foto = disco.foto;
        ViewBag.Nombre = disco.nombre;
        return View("InfoDisco");
    }
    else
    {
        ViewBag.ErrorMessage = "El disco solicitado no existe.";
        return View("Error");
    }
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
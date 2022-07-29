using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cursoAspCore.Models;

namespace cursoAspCore.Controllers;

public class EscuelaController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public EscuelaController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var escuela = new Escuela()
        {
            Nombre = "Escuela de Ejemplo",
            EscuelaID = Guid.NewGuid().ToString(),
            AñoFundacion = 2010
        };
        return View(escuela);
    } 
}

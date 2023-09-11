using Microsoft.AspNetCore.Mvc;
using practica_ing.entidades.personas;
namespace practica_ing.Controllers;

[ApiController]
[Route("[controller]")]
public class HabilidadController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<HabilidadController> _logger;

    public HabilidadController(ILogger<HabilidadController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHabilidad")]
    public Habilidad Get()
    {
        Habilidad habilidades = new Habilidad();
        habilidades.Id = 1;
        habilidades.Tecnologias = "Java, html, css";
        habilidades.AptitudesLaborales = "Trabajo en equipo, Responsabilidad";

        return habilidades;
    }
}

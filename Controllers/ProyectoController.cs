using Microsoft.AspNetCore.Mvc;
using practica_ing.entidades.personas;
namespace practica_ing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProyectoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProyectoController> _logger;

        public ProyectoController(ILogger<ProyectoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProyecto")]
        public Proyecto Get()
        {

            Proyecto proyecto1 = new Proyecto();
            proyecto1.TecnologiasUtilizadas = "Python";
            proyecto1.Redaccion = "Lenguaje de progamación python";
            proyecto1.Titulo = "Mi proyecto";
            proyecto1.LinkProyecto = "Link de mi proyecto";

            return proyecto1;

        }
    }
}

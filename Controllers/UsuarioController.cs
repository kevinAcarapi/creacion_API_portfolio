using Microsoft.AspNetCore.Mvc;
using practica_ing.entidades.personas;


namespace practica_ing.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUsuario")]
    public List<Usuario> Get()
    {

       List<Usuario> usuarios = new List<Usuario>();
       
       Usuario kevin = new Usuario();
       kevin.Id = 1;
       kevin.Nombre = "Kevin";
       kevin.Apellido = "Acarapi";
       kevin.Contrasenia = "12as34df";
       kevin.Gmail = "Kevin@gmail.com";
       kevin.Activo = true;

       usuarios.Add(kevin);

       Usuario matias = new Usuario();
       matias.Id = 2;
       matias.Nombre = "Matias";
       matias.Apellido = "Calderon";
       matias.Contrasenia = "12as34df";
       matias.Gmail = "Mati@gmail.com";
       matias.Activo = false;

       usuarios.Add(matias);

       return usuarios;

    }
}

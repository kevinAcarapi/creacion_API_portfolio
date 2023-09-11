using Microsoft.AspNetCore.Mvc;
using practica_ing.entidades.personas;
using practica_ing.dto.request;
using practica_ing.dto.response;
using System.IO.Compression;
namespace practica_ing.Controllers;

[ApiController]
[Route("[controller]")]
public class DuenioPortafolioController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<DuenioPortafolioController> _logger;

    public DuenioPortafolioController(ILogger<DuenioPortafolioController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetDuenioPortafolio")]
    public List<DuenioPortafolioResponseDTO> Get([FromQuery]DuenioPortafolioRequestDto duenioPortafolioGetDto)
    {

       List<DuenioPortafolio> duenioPortafolios = new List<DuenioPortafolio>(); 
 
       //DuenioPortafolio duenioPortafolioKevin = new DuenioPortafolio();
       
       Habilidad habilidad_A = new Habilidad
       {
        Id = 1,
        AptitudesLaborales = "Proactivo",
        Tecnologias = "Python",
       };
       Habilidad habilidad_B = new Habilidad
       {
        Id = 2,
        AptitudesLaborales = "Responsable",
        Tecnologias = "JavaScript",
       };

       Proyecto proyecto_A = new Proyecto
       {
        Id = 1,
        LinkProyecto = "www.linkProyecto.com",
        Redaccion = "Calculadora para obtener resultados de forma rapida",
        TecnologiasUtilizadas = "Python, JavaScript",
        Titulo = "Calculadora",
       };
       Proyecto proyecto_B = new Proyecto
       {
        Id = 2,
        LinkProyecto = "www.linkProyecto.com",
        Redaccion = "Reloj para obtener la hora exacta",
        TecnologiasUtilizadas = "Html, Css, JavaScript",
        Titulo = "Reloj",
       };

       DuenioPortafolio kevin = new DuenioPortafolio();

       // Herencia de la entidad "Usuario"
       kevin.Id = 1;
       kevin.Nombre = "Kevin" ;
       kevin.Apellido = "Acarapi";
       kevin.Contrasenia = "12as34df";
       kevin.Gmail = "kevinacarapi@gmail.com";
       kevin.Activo = true;

       // Relación con entidad "Habilidad"
       kevin.Habilidad = habilidad_B;

       // Relación con entidad "Proyecto"
       kevin.Proyecto = proyecto_A;

       kevin.Profesion = "Programador";
       kevin.Linkedin = "www.linkedin.com/kevin";
       kevin.Facebook = "www.facebook.com/kevin";
       kevin.Instagram = "www.instagram.com/kevin";
       kevin.Github = "www.github.com/kevin";
       kevin.Cv = "Link a mi CV";

       duenioPortafolios.Add(kevin);

       DuenioPortafolio mati = new DuenioPortafolio(); 
       // Herencia de la entidad "Usuario"
       mati.Id = 2;
       mati.Nombre = "Mati" ;
       mati.Apellido = "Amado";
       mati.Contrasenia = "12as34df";
       mati.Gmail = "matiamado@gmail.com";
       mati.Activo = true;

       // Relación con entidad "Habilidad"
       mati.Habilidad = habilidad_A;

       // Relación con entidad "Proyecto"
       mati.Proyecto = proyecto_B;

       mati.Profesion = "Programador";
       mati.Linkedin = "www.linkedin.com/mati";
       mati.Facebook = "www.facebook.com/mati";
       mati.Instagram = "www.instagram.com/mati";
       mati.Github = "www.github.com/mati";
       mati.Cv = "Link a mi CV";

       duenioPortafolios.Add(mati); 

       IEnumerable<DuenioPortafolio> listaFiltrada = duenioPortafolios.Where(x => x.Proyecto.Id == duenioPortafolioGetDto.IdProyecto && x.Proyecto.Titulo == duenioPortafolioGetDto.Titulo);

       //return listaFiltrada.ToList<DuenioPortafolio>();

       List<DuenioPortafolioResponseDTO> retorno = new List<DuenioPortafolioResponseDTO>();

        foreach(DuenioPortafolio duenioPortafolio in listaFiltrada)
        {
            retorno.Add(new DuenioPortafolioResponseDTO
            {
                Titulo = duenioPortafolio.Proyecto.Titulo,
                TecnologiasUtilizadas = duenioPortafolio.Proyecto.TecnologiasUtilizadas,
            });
        }

        return retorno;

       /*
       Habilidad python = new Habilidad();
       python.Id = 1;
       python.Tecnologias = "Python";
       python.AptitudesLaborales = "Proactivo";  
       */
       /* 
       // Herencia
       duenioPortafolioKevin.Id = 1; 
       duenioPortafolioKevin.Nombre = "Kevin";
       duenioPortafolioKevin.Apellido = "Acarapi";
       duenioPortafolioKevin.Contrasenia = "12as34df";
       duenioPortafolioKevin.Gmail = "Kevin@gmail.com";
       duenioPortafolioKevin.Activo = true; 

       // No herencia
       duenioPortafolioKevin.Profesion = "Programador";
       duenioPortafolioKevin.Linkedin = "Linkedin.com";
       duenioPortafolioKevin.Facebook = "Facebook.com";
       duenioPortafolioKevin.Instagram = "Instagram.com";
       duenioPortafolioKevin.Github = "Github.com";
       duenioPortafolioKevin.Cv = "Cv kevin acarapi";

       // Relación con entidad "Proyecto"
       duenioPortafolioKevin.TecnologiasUtilizadas = "JavaScript";
       duenioPortafolioKevin.Redaccion = "Obtener calculo matematicos de manera rapida.";
       duenioPortafolioKevin.Titulo = "Calculadora";
       duenioPortafolioKevin.LinkProyecto = "www.link.com";

       // Relación con entidad "Habilidad"

       return duenioPortafolioKevin;
       */
    }
}

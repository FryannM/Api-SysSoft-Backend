using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{


    [Route("api/[controller]")]
    public class ProyectosController : Controller
    {
    private readonly IUtilServices _utilServices;

        public ProyectosController (IUtilServices utilServices)
        {
            _utilServices = utilServices;

        }

        [HttpGet("proyectos")]
        public IActionResult Get() => Ok(_utilServices.GeAllProyectos());

        [HttpGet("proyectos-list")]
        public IActionResult Proyectos() => Ok(_utilServices.Proyectos());


        [HttpGet("{id}")]
        public IActionResult GetProyectosbyId(int id)
            => Ok(_utilServices.GetProyectos(id));

        [HttpGet("count")]
        public IActionResult Count()  => Ok(_utilServices.Count());



        [HttpPost("proyecto")]
        public OperationResult<Proyecto> Post([FromBody]ProyectoSafeDto model)
                => _utilServices.SaveProyecto(model);

        [HttpPut("proyecto")]
        public OperationResult<Proyecto> Put([FromBody]ProyectoSafeDto model)
        => _utilServices.UpdateProyecto(model);
    }
}

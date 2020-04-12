using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IUtilServices _utilServices;

        public ClientesController(IUtilServices context)
        {
            _utilServices = context;
        }

        [HttpGet("clientes")]
        public IActionResult Get() => Ok(_utilServices.GetAllClientes());


        [HttpPost("clientes")]
        public OperationResult<Cliente> Save([FromBody]ClienteDtoSave model)
            => _utilServices.SaveClientes(model);
    }
}
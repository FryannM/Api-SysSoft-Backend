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

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id) => Ok(_utilServices.GetClienteById(id));

        [HttpPost("clientes")]
        public OperationResult<Cliente> Save([FromBody]ClienteDtoSave model)
            => _utilServices.SaveClientes(model);

        [HttpPut("clientes")]
        public OperationResult<Cliente> Put([FromBody]ClienteDtoSave model)
           => _utilServices.UpdateCliente(model);
    }
}
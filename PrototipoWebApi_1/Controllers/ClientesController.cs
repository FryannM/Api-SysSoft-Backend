using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        // GET: api/    
        [HttpGet("clientes")]
        public IEnumerable<Cliente> GetClientes() => _utilServices.GetAllClientes();


        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<Cliente> GetCliente([FromRoute] int id) => await _utilServices.GetClienteById(id);

        // POST: api/Clientes
        [HttpPost("clientes")]
        public async Task<IActionResult> PostColaborador([FromBody] Cliente cliente )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await
             _utilServices.SaveCliente(cliente);

            return CreatedAtAction("GetProyectos", new { id = cliente.Cli_I_Codigo }, cliente);
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradoreServices _colaboradoreServices;
        public ColaboradorController(
            IColaboradoreServices colaboradoreServices)
        {
            _colaboradoreServices = colaboradoreServices;
        }

        [HttpGet("colaboradores")]
        public IActionResult Get() => Ok(_colaboradoreServices.GetColaboradors());

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id) => Ok(_colaboradoreServices.GetRolaboradoresById(id));

        [HttpPost("colaborador")]
        public OperationResult<Colaborador> Save([FromBody]ColaboradoresSaveDto model)
             => _colaboradoreServices.SaveColaborador(model);


        [HttpPut("colaborador")]
        public OperationResult<Colaborador> Put([FromBody]ColaboradoresSaveDto model)
           => _colaboradoreServices.UpdateColaborador(model);
       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok(_colaboradoreServices.DeleteColaborador(id));
    }
}
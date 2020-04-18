using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    public class TareasController : Controller
    {
        private readonly IUtilServices _utilServices;

        public TareasController(IUtilServices utilServices)
        {
            _utilServices = utilServices;
        }

        [HttpGet("tareas")]
        public IActionResult Get() => Ok(_utilServices.GetAllTareas());

        [HttpGet("{id}")]
        public IActionResult GetTareaById(int id) => Ok(_utilServices.GetTareaById(id));

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok(_utilServices.DeleteTarea(id));


        [HttpPost("tarea")]
        public OperationResult<Tareas> Post([FromBody]TareaSaveDto model)
            => _utilServices.SaveTareas(model);

        [HttpPut("tarea")]
        public OperationResult<Tareas> Put([FromBody]TareaSaveDto model)
         => _utilServices.UpdateTareas(model);

    }
}

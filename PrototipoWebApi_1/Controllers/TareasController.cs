using System;
using System.Collections.Generic;
using System.Linq;
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


        [HttpPost("tareas")]
        public OperationResult<Tareas> Login([FromBody]TareaSaveDto model)
            => _utilServices.SaveTareas(model);

    }
}

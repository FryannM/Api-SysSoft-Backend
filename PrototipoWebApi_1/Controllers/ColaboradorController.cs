using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public ColaboradorController(
            IColaboradoreServices colaboradoreServices,
            IMapper mapper)
        {
            _colaboradoreServices = colaboradoreServices;
            _mapper = mapper;

        }


        [HttpGet("colaboradores")]
        public IActionResult Get() => Ok(_colaboradoreServices.GetColaboradors());

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id) => Ok(_colaboradoreServices.GetRolaboradoresById(id));

        [HttpPost("colaborador")]
        public OperationResult<Colaborador> Save([FromBody]ColaboradoresSaveDto model)
             => _colaboradoreServices.SaveColaborador(model);
    }
}
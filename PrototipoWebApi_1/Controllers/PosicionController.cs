using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PosicionController : ControllerBase
    {
        // GET: /<controller>/

        private readonly IUtilServices _utilServices;
        public PosicionController(IUtilServices posicionesServices )
        {
            _utilServices = posicionesServices;

        }
        [HttpGet("posiciones")]
        public IEnumerable<Posicion> GetPosiciones() =>
            _utilServices.GetAllPosiciones();

        [HttpGet("posicionesList")]
        public IEnumerable<CargoListDto> Posiciones() =>
          _utilServices.Posiciones();


        [HttpGet("{id}")]
        public async Task<Posicion> Getposicion([FromRoute] int id)
           =>   await  _utilServices.GetPosicionById(id);


        [HttpPost("posicion")]
        public OperationResult<Posicion> Login([FromBody]PosicionDtoSave model)
            => _utilServices.SavePosicion(model);
    }

}

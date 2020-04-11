using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        private readonly IUtilServices _posicionesServices;
        public PosicionController(IUtilServices posicionesServices )
        {
            _posicionesServices = posicionesServices;

        }
        [HttpGet("posiciones")]
        public IEnumerable<Posicion> GetPosiciones() =>
            _posicionesServices.GetAllPosiciones();


        [HttpGet("{id}")]
        public async Task<Posicion> Getposicion([FromRoute] int id)
           =>   await  _posicionesServices.GetPosicionById(id);


        [HttpPost("posiciones")]
        public async Task<IActionResult> PostColaborador([FromBody] Posicion posicion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await
             _posicionesServices.SavePosicion(posicion);

            return CreatedAtAction("GetPosiciones", new { id = posicion.Pos_I_Codigo }, posicion);
        }

    }

}

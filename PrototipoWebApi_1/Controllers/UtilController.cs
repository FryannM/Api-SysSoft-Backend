using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    public class UtilController : ControllerBase
    {
        private readonly IUtilServices _utilServices;
        public UtilController( IUtilServices utilServices)
        {
            _utilServices = utilServices;

        }

        [HttpGet("posiciones")]
        public IEnumerable<Posicion> GetAllPosiciones() => _utilServices.GetAllPosiciones();


        [HttpGet("posiciones/{id}")]
        public async Task<Posicion> GetPosiciones(int id) => await _utilServices.GetPosicionById(id);


        [HttpPost("posiciones")]
        public async Task<IActionResult> PostColaborador([FromBody] Posicion posicion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await
             _utilServices.SavePosicion(posicion);

            return CreatedAtAction("GetProyectos", new { id = posicion.Pos_I_Codigo }, posicion);
        }


    }
}

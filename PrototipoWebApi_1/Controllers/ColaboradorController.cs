using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

        // GET: api/Colaboradors
        [Route("colaboladores")]
        [HttpGet]
        public IEnumerable<Colaborador> GetColaboradors()
        {
           var result = _colaboradoreServices.GetColaboradors();
            var model = _mapper.Map<IEnumerable<Colaborador>>(result);
            return model;
        }
        // GET: api/Colaboradors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColaborador([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var colaborador = await   _colaboradoreServices.GetColaboradorAsyncbyId(id);
            var model = _mapper.Map<ColaboradorDto>(colaborador);

            if (colaborador == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

       

        // POST: api/Colaboradors
        [HttpPost ("colaboradores")]
        public async Task<IActionResult> PostColaborador([FromBody] Colaborador colaborador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await
             _colaboradoreServices.SaveColaborator(colaborador);

            return CreatedAtAction("GetColaborador", new { id = colaborador.Col_I_Codigo }, colaborador);
        }

        // DELETE: api/Colaboradors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColaborador([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var colaborador = await  _colaboradoreServices.DeleteColaborador(id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return Ok(colaborador);
        }

    }
}
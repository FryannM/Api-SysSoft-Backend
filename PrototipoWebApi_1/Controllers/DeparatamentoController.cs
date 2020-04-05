using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparatamentoController : ControllerBase
    {
        private readonly IDepartamentoServices _departamentoServices;

        public DeparatamentoController( IDepartamentoServices  departamentoServices)
        {
            _departamentoServices = departamentoServices;

        }
        // GET: api/    
        [HttpGet ("departamentos")]
        public IEnumerable<Departamento> Departamentos() => _departamentoServices.GetDepartamentos();
         
        [HttpGet("{id}")]
        public Departamento DepartamentobyId(int id) => _departamentoServices.GetDepartamentosbyId(id);




        [HttpPost("departamentos")]
        public async Task<IActionResult> PostColaborador([FromBody] Departamento departamento)
        {
           if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await
             _departamentoServices.SaveDepartamento(departamento);

            return CreatedAtAction("DepartamentobyId", new { id = departamento.Dep_I_Codigo }, departamento);
        }

    }
}
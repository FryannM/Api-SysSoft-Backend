using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{


    [Route("api/[controller]")]
    public class ProyectosController : Controller
    {
    private readonly IUtilServices _utilServices;

        public ProyectosController (IUtilServices utilServices)
        {
            _utilServices = utilServices;

        }

        [HttpGet("proyectos")]
        public IActionResult Get() => Ok(_utilServices.GeAllProyectos());

        [HttpGet("{id}")]
        public async Task<Proyecto> GetProyectos(int id) => await _utilServices.GetProyectosById(id);


        [HttpPost("proyectos")]
        public async Task<IActionResult> Post([FromBody] Proyecto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await
             _utilServices.SaveProyecto(model);

            return CreatedAtAction("GetProyectos", new { id = model.Pro_I_Codigo }, model);
        }

        // PUT api/values/5
        [HttpPut("proyectos")]
        public async Task<IActionResult> Put([FromBody]Proyecto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await
             _utilServices.Update(model);

            return  CreatedAtAction("GetProyectos", new { id = model.Pro_I_Codigo }, model);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

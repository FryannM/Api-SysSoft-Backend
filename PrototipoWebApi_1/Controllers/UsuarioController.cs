using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {

        private readonly IUtilServices _utilServices;
        public UsuarioController(IUtilServices utilServices)
        {
            _utilServices = utilServices;
        }
        
        [HttpGet("usuarios")]
        public IActionResult Get() => Ok( _utilServices.GetAllUsuarios());

        [HttpGet("usuarios-list")]
        public IActionResult Usuarios() => Ok(_utilServices.Usuarios());

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
            => Ok( _utilServices.GetUsuarioById(id));

        [HttpPost("usuario")]
        public OperationResult<Usuario> Post([FromBody]UsuarioSaveDto model)
           => _utilServices.SaveUsuario(model);

        [HttpPut("usuario")]
        public OperationResult<Usuario> Put([FromBody]UsuarioSaveDto model)
        => _utilServices.UpdateUsuario(model);

        // PUT api/values/5
        [HttpPost("login")]
        public  OperationResult <Usuario> Login([FromBody]Login login)  =>  _utilServices.Login(login);

        // GET api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
            => Ok(_utilServices.DeleteUsuario(id));


    }
}

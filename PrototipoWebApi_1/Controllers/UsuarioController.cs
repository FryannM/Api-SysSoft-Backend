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

        [HttpGet("usuariosApi")]
        public IActionResult GetUsuarioApi() => Ok(_utilServices.UsuariosApi());


        [HttpGet("usuarios-list")]
        public IActionResult Usuarios() => Ok(_utilServices.Usuarios());

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
            => Ok( _utilServices.GetUsuarioById(id));

        [HttpGet("usuario/{email}")]
        public IActionResult GetUsuariobyEmail(string email)
         => Ok(_utilServices.GetuserByemail(email));


        [HttpPost("usuario")]
        public OperationResult<UsuarioApi> Post([FromBody]UsuarioSaveDto model)
           => _utilServices.SaveUsuario(model);

        [HttpPut("usuario")]
        public OperationResult<UsuarioApi> Put([FromBody]UsuarioSaveDto model)
        => _utilServices.UpdateUsuario(model);

        [HttpPut("updatepassword")]
        public OperationResult<UsuarioApi> Update([FromBody]updatePasswordDto model)
        => _utilServices.UpdatePassword(model);

        [HttpPost("login")]
        public  OperationResult <Usuario> Login([FromBody]Login login)
            =>  _utilServices.Login(login);

        [HttpPost("loginApi")]
        public UsuarioApi PostApi([FromBody]Login login)
          => _utilServices.Post(login);
            
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
            => Ok(_utilServices.DeleteUsuario(id));


    }
}

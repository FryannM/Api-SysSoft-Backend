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
    public class UsuarioController : Controller
    {

        private readonly IUtilServices _utilServices;
        public UsuarioController(IUtilServices utilServices)
        {
            _utilServices = utilServices;
        }
        
        [HttpGet("usuarios")]
        public IEnumerable<Usuario> Get() => _utilServices.GetAllUsuarios();

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Usuario> GetUsuarioById(int id)
            => await _utilServices.GetUsuarioById(id);
 

        // POST api/
        [HttpPost]
        public void Post([FromBody]Usuario usuario)
        {
        }

        // PUT api/values/5
        [HttpPost("login")]
        public  OperationResult <Usuario> Login([FromBody]Login login)  =>  _utilServices.Login(login);
        


    }
}

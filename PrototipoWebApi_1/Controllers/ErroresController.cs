using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    public class ErroresController : Controller
    {
        private readonly IUtilServices _utilServices;

        public ErroresController (IUtilServices utilServices)
        {
            _utilServices = utilServices;
        }
        // GET: api/values
        [HttpGet("errores")]
        public IEnumerable<ErroresDto> Get() => _utilServices.GetAllErrores();
       
    }
}

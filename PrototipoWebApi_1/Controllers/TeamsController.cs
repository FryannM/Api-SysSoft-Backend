using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    public class TeamsController : Controller
    {
        private readonly IUtilServices _utilServices;

        public TeamsController(IUtilServices utilServices)
        {
            _utilServices = utilServices;

        }
        [HttpGet("teams")]
        public IActionResult Get() => Ok(_utilServices.GetlAllTeams());


        [HttpPost("team")]
        public OperationResult<Team> Login([FromBody]TeamSaveDto model)
            => _utilServices.SaveTeam(model);
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrototipoWebApi_1.Controllers
{
    [Route("api/[controller]")]
    public class TeamColaboradoresController : Controller
    {
        private readonly IUtilServices _utilServices;

        public TeamColaboradoresController (IUtilServices utilServices)
        {
            _utilServices = utilServices;
        }
        // GET: api/values
        [HttpGet("teamcolaboradores")]
        public IEnumerable<TeamColaboradoresDto> Get() => _utilServices.GetAllTeamColaboradores();


        [HttpPost("teamcolaboradores")]
        public OperationResult<TeamColaboradores> Post([FromBody]TeamColaboradoresSave model)
          => _utilServices.SaveTeamColabodaroes(model);
    }
}

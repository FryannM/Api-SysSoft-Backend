using System.Collections.Generic;
using System.Linq;
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
        //[HttpGet("teamcolaboradores")]
        //public IEnumerable<TeamColaboradores> Get() => _utilServices.GetAllTeamColaboradores();

        [HttpGet("{id}")]
        public IQueryable<TeamColaboradores> Get(int id) => _utilServices.GetAllTeamColaboradores(id);

        [HttpPost("teamcolaboradores")]
        public OperationResult<TeamColaboradores> Post([FromBody]TeamColaboradores model)
          => _utilServices.SaveTeamColabodaroes(model);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Interfaces;

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
    }
}

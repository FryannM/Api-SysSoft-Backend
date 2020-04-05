using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        [HttpGet]
        public IEnumerable<Departamento> GetClientes()
        {
            var result = _departamentoServices.GetDepartamentos();
            return result;
        }

        [HttpGet("{id}")]
        public Departamento GetDepartamentobyId(int id)
        {
            var result = _departamentoServices.GetDepartamentosbyId(id);

            return result;
                
        }
    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
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
        [HttpGet ("departamentos")]
        public IEnumerable<Departamento> Departamentos() => _departamentoServices.GetDepartamentos();

        [HttpGet("departamentos-list")]
        public IEnumerable<DepartamentoListDto> DepartamentosList() => _departamentoServices.Departamentos();

        [HttpGet("{id}")]
        public Departamento DepartamentobyId(int id) => _departamentoServices.GetDepartamentosbyId(id);



        [HttpPost("departamento")]
        public OperationResult<Departamento> Post([FromBody]DepartamentoSaveDto model)
           => _departamentoServices.SaveDepartamento(model);

        [HttpPut("departamento")]   
        public OperationResult<Departamento> Put([FromBody]DepartamentoSaveDto model)
        => _departamentoServices.UpdateDepartamento(model);
    }
}
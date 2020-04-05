using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;
using PrototipoWebApi_1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Services
{
    public class DepartamentoServices : IDepartamentoServices
    {
        RepositoryBase _DepartamentoServices;

        public DepartamentoServices( RepositoryBase DepartamentoServices)
        {
            _DepartamentoServices = DepartamentoServices;
        }       
        public IEnumerable<Departamento> GetDepartamentos()
        {
            var result = _DepartamentoServices.Departamentos;
            return result;
        }

        public Departamento GetDepartamentosbyId(int id)
        {
            var result = _DepartamentoServices.Departamentos.Find(id);

            return result;

        }
    }
}

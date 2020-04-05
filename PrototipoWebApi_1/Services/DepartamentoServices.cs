using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;
using PrototipoWebApi_1.Repositorios;

namespace PrototipoWebApi_1.Services
{
    public class DepartamentoServices : IDepartamentoServices
    {
        RepositoryBase _departamentoServices;

        public DepartamentoServices( RepositoryBase DepartamentoServices)
        {
            _departamentoServices = DepartamentoServices;
        }       
        public IEnumerable<Departamento> GetDepartamentos()
        {
            var result = _departamentoServices.Departamentos;
            return result;
        }

        public Departamento GetDepartamentosbyId(int id)
        {
            var result = _departamentoServices.Departamentos.Find(id);

            return result;

        }

        public  async Task<Departamento> SaveDepartamento(Departamento departamento)
        {
            try
            {

                var result = _departamentoServices.Departamentos.AddAsync(departamento);
                _departamentoServices.Entry(departamento).State = EntityState.Detached;
                await _departamentoServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return departamento;
        }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;
using PrototipoWebApi_1.Repositorios;

namespace PrototipoWebApi_1.Services
{
    public class DepartamentoServices : IDepartamentoServices
    {
        RepositoryBase _departamentoServices;

        public DepartamentoServices(RepositoryBase DepartamentoServices)
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

        public OperationResult<Departamento> SaveDepartamento(DepartamentoSaveDto departamento)
        {
            var result = new OperationResult<Departamento>();

            try
            {
                _departamentoServices.Departamentos.Add(departamento.MapModel());
                _departamentoServices.SaveChanges();

                result.Success = true;
                result.ResultObject = departamento.MapModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public OperationResult<Departamento> UpdateDepartamento(DepartamentoSaveDto departamento)
        {
            var result = new OperationResult<Departamento>();

            try
            {
                _departamentoServices.Departamentos.Update(departamento.MapModel());
                _departamentoServices.SaveChanges();

                result.Success = true;
                result.ResultObject = departamento.MapModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public IEnumerable<DepartamentoListDto> Departamentos() =>

       _departamentoServices.Departamentos.Select(x => new DepartamentoListDto
               {
                   Id = x.Dep_I_Codigo,
                   Descripcion = x.Dep_V_Descripcion
               });

    }
}


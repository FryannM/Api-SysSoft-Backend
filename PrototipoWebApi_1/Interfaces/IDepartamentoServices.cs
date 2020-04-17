using System.Collections.Generic;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Interfaces
{
    public  interface IDepartamentoServices
    {
      
        IEnumerable<Departamento> GetDepartamentos();
        Departamento GetDepartamentosbyId(int id);
        OperationResult<Departamento> SaveDepartamento(DepartamentoSaveDto departamento);
        OperationResult<Departamento> UpdateDepartamento(DepartamentoSaveDto departamento);
        IEnumerable<DepartamentoListDto> Departamentos();

    }
}

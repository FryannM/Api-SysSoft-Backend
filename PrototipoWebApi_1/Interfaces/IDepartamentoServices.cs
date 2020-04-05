using System.Collections.Generic;
using System.Threading.Tasks;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Interfaces
{
    public  interface IDepartamentoServices
    {
      
        IEnumerable<Departamento> GetDepartamentos();
        Departamento GetDepartamentosbyId(int id);
        Task<Departamento> SaveDepartamento(Departamento departamento);

    }
}

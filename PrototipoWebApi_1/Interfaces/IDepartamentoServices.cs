using PrototipoWebApi_1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Interfaces
{
     public  interface IDepartamentoServices
    {
      
        IEnumerable<Departamento> GetDepartamentos();
        Departamento GetDepartamentosbyId(int id);
    }
}

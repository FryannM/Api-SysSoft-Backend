using System.Collections.Generic;
using System.Threading.Tasks;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Interfaces
{
    public interface IColaboradoreServices
    {

        IEnumerable<ColaboradoresDto> GetColaboradors();
        ColaboradoresDto GetRolaboradoresById(int id);
        OperationResult<Colaborador> SaveColaborador(ColaboradoresSaveDto colaborador);
        Task<Colaborador> DeleteColaborador(int id);
    }
}

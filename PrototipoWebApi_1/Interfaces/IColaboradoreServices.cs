using System.Collections.Generic;
using System.Threading.Tasks;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Interfaces
{
    public interface IColaboradoreServices
    {

        IEnumerable<Colaborador> GetColaboradors();
         Task<Colaborador> GetColaboradorAsyncbyId(int id);
         Task<Colaborador> SaveColaborator(Colaborador colaborador);
         Task<Colaborador> DeleteColaborador(int id);
    }
}

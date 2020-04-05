using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;
using PrototipoWebApi_1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Services
{
    public class ColaboradorServices : IColaboradoreServices
    {
        private readonly RepositoryBase _colaboradorServices;


        public ColaboradorServices( RepositoryBase colaboradorServices)
        {
            _colaboradorServices = colaboradorServices;
        }
        public IEnumerable<Colaborador> GetColaboradors()
        {
            var colaboradores = _colaboradorServices.Colaboradors;
            return colaboradores;
            
        }

        public async Task<Colaborador> GetColaboradorAsyncbyId(int id)
        {
            var colaborador = await _colaboradorServices.Colaboradors.FindAsync(id);
            return colaborador;
                
        }

        public async Task<Colaborador> SaveColaborator(Colaborador colaborador)
        {
            try
            {

          var result =  _colaboradorServices.Colaboradors.AddAsync(colaborador);
             await _colaboradorServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return colaborador;
           
        }

        public async Task<Colaborador> DeleteColaborador(int id)
        {
            var result = await
                _colaboradorServices.Colaboradors.FindAsync(id);
           
            _colaboradorServices.Colaboradors.Remove(result);
            await _colaboradorServices.SaveChangesAsync();
            return result;
        }   
    }
}

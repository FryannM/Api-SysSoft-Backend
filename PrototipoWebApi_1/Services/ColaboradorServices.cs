using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
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


        public ColaboradorServices(RepositoryBase colaboradorServices)
        {
            _colaboradorServices = colaboradorServices;
        }
        public IEnumerable<ColaboradoresDto> GetColaboradors()
        {
            var result = _colaboradorServices.Colaboradors
                   .Select(x => new ColaboradoresDto
                   {
                       Id = x.Col_I_Codigo,
                       Nombre1 = string.Concat(x.Col_V_Nombre_1, " ", x.Col_V_Nombre_2),
                       Apellido1 = string.Concat(x.Col_V_Apellido_1, " ", x.Col_V_Apellido_2),
                       Cedula = x.Col_V_Cedula,
                       Sexo = x.Col_C_Sexo,
                       Estado = x.Col_B_Estado,
                       Fecha_Nacimiento = x.Col_D_Fecha_Nacimiento,
                       Departamento = x.Departamentos.Dep_V_Descripcion,
                       Pocisiones = x.Pocisiones.Pos_V_Descripcion
                   }).Where( x => x.Estado == 'A');

            return result;

        }

        public OperationResult<Colaborador> SaveColaborador(ColaboradoresSaveDto colaborador)
        {
            var result = new OperationResult<Colaborador>();

            try
            {
                _colaboradorServices.Colaboradors.Add(colaborador.MapModel());
                _colaboradorServices.SaveChanges();

                result.Success = true;
                result.ResultObject = colaborador.MapModel();
            }
            catch (Exception ex)
            {
                _colaboradorServices.Errores.Add(ex.SaveModel());
                _colaboradorServices.SaveChanges();
                throw ex;
            }
            return result;
        }


        public OperationResult<Colaborador> UpdateColaborador(ColaboradoresSaveDto colaborador)
        {
            var result = new OperationResult<Colaborador>();

            try
            {
                _colaboradorServices.Colaboradors.Update(colaborador.MapModel());
                _colaboradorServices.SaveChanges();

                result.Success = true;
                result.ResultObject = colaborador.MapModel();
            }
            catch (Exception ex)
            {
                _colaboradorServices.Errores.Add(ex.SaveModel());
                _colaboradorServices.SaveChanges();
                throw ex;
            }
            return result;
        }



        public ColaboradoresDto GetRolaboradoresById(int id)
        {

            var result = new ColaboradoresDto();

            try
            {
                result = _colaboradorServices.Colaboradors
                 .Select(x => new ColaboradoresDto
                 {
                     Id = x.Col_I_Codigo,
                     Nombre1 = x.Col_V_Nombre_1,
                     Nombre2 = x.Col_V_Nombre_2,
                     Apellido1 = x.Col_V_Apellido_1,
                     Apellido2 = x.Col_V_Apellido_2,
                     Cedula = x.Col_V_Cedula,
                     Estado = x.Col_B_Estado,
                     Sexo = x.Col_C_Sexo,
                     Fecha_Nacimiento = x.Col_D_Fecha_Nacimiento,
                     Departamento = x.Departamentos.Dep_I_Codigo.ToString(),
                     Pocisiones = x.Pocisiones.Pos_I_Codigo.ToString()
                 }).Where(x => x.Id == id).Single();

            }
            catch (Exception ex)
            {
                _colaboradorServices.Errores.Add(ex.SaveModel());
                _colaboradorServices.SaveChanges();
                throw ex;
            }
          
            return result;

        }


        public async Task<Colaborador> SaveColaborator(Colaborador colaborador)
        {
            try
            {

                var result = _colaboradorServices.Colaboradors.AddAsync(colaborador);
                await _colaboradorServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _colaboradorServices.Errores.Add(ex.SaveModel());
                _colaboradorServices.SaveChanges();
                throw ex;
            }

            return colaborador;

        }
        public OperationResult<Colaborador> DeleteColaborador(int id)
        {
            var result = new OperationResult<Colaborador>();
            var colaborador = _colaboradorServices.Colaboradors.Find(id);
            try
            {
                _colaboradorServices.Colaboradors.Remove(colaborador);
                _colaboradorServices.SaveChanges();

                result.Success = true;
                result.ResultObject = colaborador;
            }
            catch (Exception ex)
            {
                _colaboradorServices.Errores.Add(ex.SaveModel());
                _colaboradorServices.SaveChanges();
                throw ex;
            }
            return result;
        }


        public TotalReacord TotalColaboradores()
        {
            var count = _colaboradorServices.Colaboradors.Count();
            var model = new TotalReacord()
            {
                TotalRecord = count
            };
            return model;
        }
    }
}

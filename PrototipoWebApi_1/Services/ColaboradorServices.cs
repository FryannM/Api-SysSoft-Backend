﻿using PrototipoWebApi_1.Abstract;
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


        public ColaboradorServices( RepositoryBase colaboradorServices)
        {
            _colaboradorServices = colaboradorServices;
        }
        public IEnumerable<ColaboradoresDto> GetColaboradors()
        {
            var result = _colaboradorServices.Colaboradors
                   .Select(x => new ColaboradoresDto
                   {
                       Codigo = x.Col_I_Codigo,
                       Nombres = string.Concat(x.Col_V_Nombre_1," ",x.Col_V_Nombre_2),
                       Apellidos = string.Concat(x.Col_V_Apellido_1, " ", x.Col_V_Apellido_2),
                       Cedula = x.Col_V_Cedula,
                       Sexo = x.Col_C_Sexo,
                       Estado = x.Col_B_Estado,
                       Fecha_Nacimiento = x.Col_D_Fecha_Nacimiento,
                       Departamentos = x.Departamentos.Dep_V_Descripcion,
                       Pocisiones = x.Pocisiones.Pos_V_Descripcion
                   });

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
                throw ex;
            }
            return result;
        }



        public ColaboradoresDto GetRolaboradoresById(int id)
        {
            var result = _colaboradorServices.Colaboradors
                   .Select(x => new ColaboradoresDto
                   {
                       Codigo = x.Col_I_Codigo,
                       Nombres = string.Concat(x.Col_V_Nombre_1, " ", x.Col_V_Nombre_2),
                       Apellidos = string.Concat(x.Col_V_Apellido_1, " ", x.Col_V_Apellido_2),
                       Cedula = x.Col_V_Cedula,
                       Estado = x.Col_B_Estado,
                       Sexo= x.Col_C_Sexo,
                       Fecha_Nacimiento = x.Col_D_Fecha_Nacimiento,
                       Departamentos = x.Departamentos.Dep_V_Descripcion,
                       Pocisiones = x.Pocisiones.Pos_V_Descripcion
                   }).Where(x => x.Codigo == id).Single();

            return result;

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

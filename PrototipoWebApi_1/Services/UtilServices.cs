using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Modelos;
using PrototipoWebApi_1.Repositorios;

namespace PrototipoWebApi_1.Services
{
    public class PosicionServices : IUtilServices
    {

        private readonly RepositoryBase _utilServices;
        private readonly IMapper _mapper;

        public PosicionServices(RepositoryBase utilServices,
            IMapper mapper)
        {
            _utilServices = utilServices;
            _mapper = mapper;
        }

        /// <summary>
        /// Posicion Mantenimientos 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Posicion> GetAllPosiciones()  => _utilServices.Posicion;
        public async Task<Posicion> GetPosicionById(int id)  => await _utilServices.Posicion.FindAsync(id);

        public async Task<Posicion> SavePosicion(Posicion posicion)
        {
            try
            {
                var result = _utilServices.Posicion.AddAsync(posicion);
                await _utilServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return posicion;
        }
        /// <summary>
        /// Team Services
        /// </summary>
        /// <returns></returns>

        public IEnumerable<Team> GetlAllTeams() =>  _utilServices.Team;
        public async Task<Team> GetlTeamsById(int id) => await _utilServices.Team.FindAsync(id);
        
        public async  Task<Team> SaveTeam(Team team)
        {
            try
            {
                var result = _utilServices.Team.AddAsync(team);
                await _utilServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return team;
        }
        /// <summary>
        ///  Proyectos Mantenimientos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Proyecto> GeAllProyectos() =>
            _utilServices.Proyectos;


        public async Task<Proyecto> GetProyectosById(int id) => await _utilServices.Proyectos.FindAsync(id);
      

        public  async Task<Proyecto> SaveProyecto(Proyecto proyecto)
        {
            try
            {
               var result = _utilServices.Proyectos.AddAsync(proyecto);
                await _utilServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return proyecto;
        }

        public async Task<Proyecto> Update(Proyecto proyectos)
        {
            var result = await _utilServices.Proyectos.FindAsync(proyectos.Pro_I_Codigo);

            try
            {
                 _utilServices.Proyectos.Update(result);
                _utilServices.Entry(result).State = EntityState.Modified;

                await _utilServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }





        /// <summary>
        /// Cliente Mantenimientos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cliente> GetAllClientes() => _utilServices.Clientes;
        public async Task<Cliente> GetClienteById(int id) =>  await _utilServices.Clientes.FindAsync(id);
       
        public async  Task<Cliente> SaveCliente(Cliente cliente)
        {
            try
            {
                var result = _utilServices.Clientes.AddAsync(cliente);
                await _utilServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cliente;
        }

        /// <summary>
        /// Usuario Mantenimiento
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Usuario> GetAllUsuarios() => _utilServices.Usuario;

        public async Task<Usuario> GetUsuarioById(int id) => await _utilServices.Usuario.FindAsync(id);


        public OperationResult<Usuario> SaveUsuario(Usuario usuario)
        {
            var result = new OperationResult<Usuario>();
           
            try
            {
                _utilServices.Usuario.AddAsync(usuario);
                _utilServices.SaveChangesAsync();

                result.Success = true;
                result.ResultObject = usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return  result;
        }

        public OperationResult<Usuario> Login(Login login)
        {
            var result = new OperationResult<Usuario>();
            var log = _utilServices.Usuario
             .Where(x => x.Usr_V_NombreUsuario == login.Usr_V_NombreUsuario &&
            x.Usr_V_PassWord == login.Usr_V_PassWord).SingleOrDefault();
          var model =  _mapper.Map<Usuario>(log);
            result.Success = true;
            result.ResultObject = model;
            return result;
        }

       
    }
}

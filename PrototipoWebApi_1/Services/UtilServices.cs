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
        public IEnumerable<Posicion> GetAllPosiciones() => _utilServices.Posicion;
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

        public IEnumerable<TeamDto> GetlAllTeams()
        {
            var result = _utilServices.Team
                    .Select(x => new TeamDto
                    {
                        Codigo = x.Codigo,
                        Descripcion = x.Descripcion,
                        Proyecto = x.Proyecto.Pro_V_Descripcion,
                        CantidadIntegrantes = x.CantidadIntegrantes,
                        Estado = x.Estado,
                        FechaCreacion = x.FechaCreacion
                    });

            return result;
        }


        public async Task<Team> GetlTeamsById(int id) => await _utilServices.Team.FindAsync(id);


        private Team MapModel(TeamSaveDto team)
        {
            return new Team
            {
                Codigo = team.Codigo,
                Descripcion = team.Descripcion,
                Estado = team.Estado,
                CantidadIntegrantes = team.CantidadIntegrantes,
                Pro_I_Codigo = team.Pro_I_Codigo,
                FechaCreacion = team.FechaCreacion,
            };
        }
        public OperationResult<Team> SaveTeam(TeamSaveDto team)
        {
            var result = new OperationResult<Team>();
            var model = MapModel(team);

            try
            {
                _utilServices.Team.Add(model);
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
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

            try
            {
                 _utilServices.Proyectos.Update(proyectos);
                _utilServices.Entry(proyectos).State = EntityState.Modified;

                await _utilServices.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return proyectos;
        }











        /// <summary>
        /// Cliente Mantenimientos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ClienteDto> GetAllClientes()
        {
            var result = _utilServices.Clientes
                    .Select(x => new ClienteDto
                    {
                        Codigo = x.Cli_I_Codigo,
                        Nombre1 = x.Cli_V_Nombre_1,
                        Nombre2 = x.Cli_V_Nombre_2,
                        Apellido1 = x.Cli_V_Apellido_1,
                        Apellido2 = x.Cli_V_Apellido_2,
                       CedulaRnc   = x.Cli_V_CedulaRnc,
                       Telefono = x.Cli_V_Telefono,
                       Email  = x.Cli_V_email,
                       Proyecto = x.Proyecto.Pro_V_Descripcion,
                    });

            return result;
        }

        public   ClienteDto GetClienteById(int id)
        {
            var result = _utilServices.Clientes
                    .Select(x => new ClienteDto
                    {
                        Codigo = x.Cli_I_Codigo,
                        Nombre1 = x.Cli_V_Nombre_1,
                        Nombre2 = x.Cli_V_Nombre_2,
                        Apellido1 = x.Cli_V_Apellido_1,
                        Apellido2 = x.Cli_V_Apellido_2,
                        CedulaRnc = x.Cli_V_CedulaRnc,
                        Telefono = x.Cli_V_Telefono,
                        Email = x.Cli_V_email,
                        Proyecto = x.Proyecto.Pro_V_Descripcion,
                    }).Where(x => x.Codigo == id).Single() ;

            return result;
        }

        private Cliente MapModel(ClienteDtoSave clientes)
        {
            return new Cliente
            {
                Cli_I_Codigo = clientes.Codigo,
                Cli_V_Nombre_1 = clientes.Nombre1,
                Cli_V_Nombre_2 = clientes.Nombre2,
                Cli_V_Apellido_1 = clientes.Apellido1,
                Cli_V_Apellido_2 = clientes.Apellido2,
                Cli_V_CedulaRnc = clientes.CedulaRnc,
                Cli_V_email = clientes.Email,
                Cli_V_Telefono = clientes.Telefono,
                Pro_I_Codigo = clientes.Proyecto,

            };
        }

        public OperationResult<Cliente> SaveClientes(ClienteDtoSave cliente)
        {
            var result = new OperationResult<Cliente>();
            var model = MapModel(cliente);

            try
            {
                _utilServices.Clientes.Add(model);
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
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
                _utilServices.Usuario.Add(usuario);
                _utilServices.SaveChanges();

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
        /// <summary>
        /// Tareas Mantenimiento
        /// </summary>
        /// <returns></returns>

        public IEnumerable<TareasDto> GetAllTareas()
        {

                var result = _utilServices.Tareas
                        .Select(x =>  new TareasDto
                        {
                           Codigo = x.Codigo,
                           Estado = x.Estado,
                           Fecha = x.FechaCreacion,
                           Titulo = x.Titulo,
                           Usuario = x.Usuario.Usr_V_Nombre,
                           Proyecto = x.Proyecto.Pro_V_Descripcion,
                           Comentario = x.Comentario
                        });
           
            return result;
        }
            
           


        public  TareasDto GetTareaById(int id)
        {
            var result =   _utilServices.Tareas
                        .Select(x => new TareasDto
                        {
                            Codigo = x.Codigo,
                            Estado = x.Estado,
                            Fecha = x.FechaCreacion,
                            Titulo = x.Titulo,
                            Usuario = x.Usuario.Usr_V_Nombre,
                            Proyecto = x.Proyecto.Pro_V_Descripcion,
                            Comentario = x.Comentario
                        }).Where(x => x.Codigo == id).Single();

            return   result;
        }


        private Tareas  MapModel(TareaSaveDto tareas)
        {
            return new Tareas
            {
                Codigo = tareas.Codigo,
                Titulo = tareas.Titulo,
                Estado = tareas.Estado,
                FechaCreacion = tareas.Fecha,
                Pro_I_Codigo = tareas.CodigoProyecto,
                Usr_I_CodigoUsuario = tareas.CodigoUsuario,
                Comentario = tareas.Comentario,
            };
        }

        public OperationResult<Tareas> SaveTareas(TareaSaveDto tareas)
        {
            var result = new OperationResult<Tareas>();
            var model = MapModel(tareas);

            try
            {
                _utilServices.Tareas.Add(model);
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

      
    }
}

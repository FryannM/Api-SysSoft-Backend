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
        public async Task<Posicion> GetPosicionById(int id) => await _utilServices.Posicion.FindAsync(id);

        public OperationResult<Posicion> SavePosicion(PosicionDtoSave posicion)
        {
            var result = new OperationResult<Posicion>();

            try
            {
                _utilServices.Posicion.Add(posicion.MapModel());
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = posicion.MapModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
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




        public TeamDto GetlTeamsById(int id)
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
                       }).Where(x => x.Codigo == id).Single();

            return result;
        }


        public OperationResult<Team> SaveTeam(TeamSaveDto team)
        {
            var result = new OperationResult<Team>();

            try
            {
                _utilServices.Team.Add(team.MapModel());
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = team.MapModel();
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


        public IEnumerable<ProyectosListDto> Proyectos() =>

          _utilServices.Proyectos.Select(x => new ProyectosListDto
          {
              Codigo = x.Pro_I_Codigo,
              Descripcion = x.Pro_V_Descripcion
          });



        public async Task<Proyecto> GetProyectosById(int id) => await _utilServices.Proyectos.FindAsync(id);


        public async Task<Proyecto> SaveProyecto(Proyecto proyecto)
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
                        Nombre1 = string.Concat(x.Cli_V_Nombre_1, " ", x.Cli_V_Nombre_2),
                        Apellido1 = string.Concat(x.Cli_V_Apellido_1, " ", x.Cli_V_Apellido_2),
                        CedulaRnc = x.Cli_V_CedulaRnc,
                        Telefono = x.Cli_V_Telefono,
                        Email = x.Cli_V_email,
                        Proyecto = x.Proyecto.Pro_V_Descripcion,
                        Estado = x.Estado
                    });

            return result;
        }

        public ClienteDto GetClienteById(int id)
        {
            var result = _utilServices.Clientes
                    .Select(x => new ClienteDto
                    {
                        Codigo = x.Cli_I_Codigo,
                        Nombre1 = string.Concat(x.Cli_V_Nombre_1, " ", x.Cli_V_Nombre_2),
                        Apellido1 = string.Concat(x.Cli_V_Apellido_1, " ", x.Cli_V_Apellido_2),
                        CedulaRnc = x.Cli_V_CedulaRnc,
                        Telefono = x.Cli_V_Telefono,
                        Email = x.Cli_V_email,
                        Proyecto = x.Proyecto.Pro_V_Descripcion,
                        Estado = x.Estado,
                    }).Where(x => x.Codigo == id).Single();

            return result;
        }



        public OperationResult<Cliente> UpdateCliente(ClienteDtoSave cliente)
        {
            var result = new OperationResult<Cliente>();

            try
            {
                _utilServices.Update(cliente.MapModel());
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = cliente.MapModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }



        public OperationResult<Cliente> SaveClientes(ClienteDtoSave cliente)
        {
            var result = new OperationResult<Cliente>();

            try
            {
                _utilServices.Clientes.Add(cliente.MapModel());
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = cliente.MapModel();
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
        public IEnumerable<UsuarioDto> GetAllUsuarios()
        {
            var result = _utilServices.Usuario
                    .Select(x => new UsuarioDto
                    {
                        Codigo = x.Usr_I_CodigoUsuario,
                        Nombre = x.Usr_V_Nombre,
                        NombreUsuario = x.Usr_V_NombreUsuario,
                        PassWord = x.Usr_V_PassWord,
                        Cargo = x.Cargo.Pos_V_Descripcion,
                        Email = x.Usr_V_Email,
                        Estado = x.Estado
                    });

            return result;
        }


        public UsuarioDto GetUsuarioById(int id)
        {
            var result = _utilServices.Usuario
                    .Select(x => new UsuarioDto
                    {
                        Codigo = x.Usr_I_CodigoUsuario,
                        Nombre = x.Usr_V_Nombre,
                        NombreUsuario = x.Usr_V_NombreUsuario,
                        PassWord = x.Usr_V_PassWord,
                        Cargo = x.Cargo.Pos_V_Descripcion,
                        Email = x.Usr_V_Email,
                        Estado = x.Estado
                    }).Where(x => x.Codigo == id).Single();

            return result;
        }


        public OperationResult<Usuario> SaveUsuario(UsuarioSaveDto usuario)
        {
            var result = new OperationResult<Usuario>();

            try
            {
                _utilServices.Usuario.Add(usuario.MapModel());
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = usuario.MapModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public OperationResult<Usuario> UpdateUsuario(UsuarioSaveDto usuario)
        {
            var result = new OperationResult<Usuario>();

            try
            {
                _utilServices.Usuario.Update(usuario.MapModel());
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = usuario.MapModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
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
                    .Select(x => new TareasDto
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


        public OperationResult<Tareas> SaveTareas(TareaSaveDto tareas)
        {
            var result = new OperationResult<Tareas>();

            try
            {
                _utilServices.Tareas.Add(tareas.MapModel());
                _utilServices.SaveChanges();

                result.Success = true;
                result.ResultObject = tareas.MapModel();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}

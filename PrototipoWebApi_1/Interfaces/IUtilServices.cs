﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrototipoWebApi_1.Abstract;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Interfaces
{
    public interface IUtilServices
    {
        IEnumerable<Posicion> GetAllPosiciones();
        Task <Posicion> GetPosicionById(int id);
        OperationResult<Posicion> SavePosicion(PosicionDtoSave posicion);
        OperationResult<Posicion> UpdatePosicion(PosicionDtoSave posicion);

        IEnumerable<CargoListDto> Posiciones();

        IEnumerable<TeamDto> GetlAllTeams();
        TeamDto GetlTeamsById(int id);
        OperationResult<Team> SaveTeam(TeamSaveDto team);
        OperationResult<Team> UpdateTeam(TeamSaveDto team);


        IEnumerable<ProyectoDto> GeAllProyectos();
        OperationResult<Proyecto> SaveProyecto(ProyectoSafeDto proyecto);
        OperationResult<Proyecto> UpdateProyecto(ProyectoSafeDto proyecto);
        IEnumerable<ProyectosListDto> Proyectos();
        ProyectoDto GetProyectos(int id);
        int TotalProyectos(int id);


        IEnumerable <UsuarioDto> GetAllUsuarios();
        UsuarioDto GetUsuarioById(int id);
        OperationResult<UsuarioApi> SaveUsuario(UsuarioSaveDto usuario);
        OperationResult<UsuarioApi> UpdateUsuario(UsuarioSaveDto usuario);
        IEnumerable<UsuarioListDto> Usuarios();
        OperationResult<Usuario> DeleteUsuario(int Id);
        IEnumerable<UsuarioApi> UsuariosApi();
        UsuarioApi Post(Login login);
        UsuarioApi GetuserByemail(string email);
        OperationResult<UsuarioApi> UpdatePassword(updatePasswordDto usuario);


        OperationResult<Usuario> Login(Login login);


        IEnumerable<TareasDto> GetAllTareas();
        TareasDto GetTareaById(int id);
        OperationResult<Tareas> SaveTareas(TareaSaveDto tarea);
        OperationResult<Tareas> UpdateTareas(TareaSaveDto tarea);
        OperationResult<Tareas> DeleteTarea(int Id);


        IEnumerable<ClienteDto> GetAllClientes();
        ClienteDto GetClienteById(int id);
        OperationResult<Cliente> SaveClientes(ClienteDtoSave cliente);
        OperationResult<Cliente> UpdateCliente(ClienteDtoSave cliente);
        int TotalClientes(int id);
        IEnumerable<ErroresDto> GetAllErrores();
        OperationResult<Cliente> DeleteCliente(int Id);


        //IEnumerable<TeamColaboradoresDto> GetAllTeamColaboradores();
        // IEnumerable<TeamColaboradores> GetAllTeamColaboradores();

        // TeamColaboradoresDto GetAllTeamColaboradores();
        // TeamColaboradoresDto GetAllTeamColaboradores(int id);
        //TeamColaboradores GetAllTeamColaboradores(int id);
        IQueryable<TeamColaboradores> GetAllTeamColaboradores(int id);
       // IQueryable<TeamSingle> GetAllTeamColaboradores(int id);

        OperationResult<TeamColaboradores> SaveTeamColabodaroes(TeamColaboradores team);
       // OperationResult<TeamColaboradores> SaveTeamColabodaroes(TeamColaboradoresSave team);

    }
}

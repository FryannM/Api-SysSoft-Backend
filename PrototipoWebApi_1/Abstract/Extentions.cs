using System;
using PrototipoWebApi_1.Dtos;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Abstract
{
    public static class Extentions
    {

       


        public static UsuarioApi MapModel(this UsuarioSaveDto usuarios)
        {
            return new UsuarioApi
            {
                Id = usuarios.Id,
                Name = usuarios.Name,
                UserName = usuarios.UserName,
                Password = usuarios.PassWord,
                Email = usuarios.Email,
                Pos_I_Codigo = usuarios.Cargo,
                Estado = usuarios.Estado
            };
        }
        

        public static Cliente MapModel( this ClienteDtoSave clientes)
        {
            return new Cliente
            {
                Cli_I_Codigo = clientes.Id,
                Cli_V_Nombre_1 = clientes.Nombre1,
                Cli_V_Nombre_2 = clientes.Nombre2,
                Cli_V_Apellido_1 = clientes.Apellido1,
                Cli_V_Apellido_2 = clientes.Apellido2,
                Cli_V_CedulaRnc = clientes.CedulaRnc,
                Cli_V_email = clientes.Email,
                Cli_V_Telefono = clientes.Telefono,
                Pro_I_Codigo = clientes.Proyecto,
                Estado = clientes.Estado

            };
        }


        public  static Tareas MapModel( this TareaSaveDto tareas)
        {
            return new Tareas
            {
                Codigo = tareas.Id,
                Titulo = tareas.Titulo,
                Estado = tareas.Estado,
                FechaCreacion = tareas.Fecha,
                Pro_I_Codigo = tareas.Proyecto,
                Usr_I_CodigoUsuario = tareas.Usuario,
                Comentario = tareas.Comentario,
            };
        }

        public static Team MapModel( this TeamSaveDto team)
        {
            return new Team
            {
                Codigo = team.Id,
                Descripcion = team.Descripcion,
                Estado = team.Estado,
                CantidadIntegrantes = team.CantidadIntegrantes,
                Pro_I_Codigo = team.Proyecto,
                FechaCreacion = team.FechaCreacion,
            };
        }


        public static Posicion MapModel(this PosicionDtoSave posicion)
        {
            return new Posicion
            {
                Pos_I_Codigo = posicion.Id,
                Pos_V_Descripcion = posicion.Descripcion,
                Estado = posicion.Estado,
                Perfil = posicion.Perfil,
                Sueldo = posicion.Sueldo,
            };
        }

        public static Colaborador MapModel(this ColaboradoresSaveDto colaboradors)
        {
            return new Colaborador
            {
                Col_I_Codigo = colaboradors.Id,
                Col_V_Nombre_1 = colaboradors.Nombre1,
                Col_V_Nombre_2 = colaboradors.Nombre2,
                Col_V_Apellido_1 = colaboradors.Apellido1,
                Col_V_Apellido_2 = colaboradors.Apellido2,
                Col_V_Cedula = colaboradors.Cedula,
                Col_B_Estado = colaboradors.Estado,
                Col_C_Sexo = colaboradors.Sexo,
                Col_D_Fecha_Nacimiento = colaboradors.Fecha_Nacimiento,
                Dep_I_Codigo = colaboradors.Departamento,
                Pos_I_Codigo = colaboradors.Pocisiones
            };
        }

        public static Departamento MapModel(this DepartamentoSaveDto x)
        {
            return new Departamento
            {
                Dep_I_Codigo = x.Id,
                Dep_V_Descripcion = x.Descripcion,
                Nombre = x.Nombre,
                Estado = x.Estado,
               
            };
        }

        public static Proyecto MapModel(this ProyectoSafeDto x)
        {
            return new Proyecto
            {
                Pro_I_Codigo= x.Id,
                Pro_V_Descripcion = x.Descripcion,
                Fecha_Inicio = x.FechaInicio,
                Fecha_Fin = x.FechaFin,
                Estado = x.Estado,
            };
        }


        public static Errores SaveModel(this Exception x)
        {
            return new Errores
            {
                Mensaje = x.Message,
                StackTrace = x.StackTrace,
                Source = x.Source,
                Usr_I_CodigoUsuario = 1
            };
        }

        public static TeamColaboradores MapModel(this TeamColaboradoresSave x)
        {
            var result =  new  TeamColaboradores()
            { 
                Codigo = x.TeamCodigo,
                Col_I_Codigo = x.ColaboradorCodigo,
                Estado = x.Estado,
                Fecha = x.Fecha,
            };

            return result;
        }

    }
}



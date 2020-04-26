using Microsoft.EntityFrameworkCore;
using PrototipoWebApi_1.Modelos;

namespace PrototipoWebApi_1.Repositorios
{
    public class RepositoryBase :  DbContext

    {
        public RepositoryBase( DbContextOptions<RepositoryBase> options) :base(options)
        {

        }
        public DbSet<Colaborador> Colaboradors { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Posicion> Posicion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Errores> Errores { get; set; }
        public DbSet<TeamColaboradores> TeamColaboradores { get; set; }
        public DbSet<UsuarioApi> UsuarioApi { get; set; }

    }
}

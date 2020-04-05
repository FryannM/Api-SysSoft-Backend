using Microsoft.EntityFrameworkCore;
using PrototipoWebApi_1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        
       


    }
}

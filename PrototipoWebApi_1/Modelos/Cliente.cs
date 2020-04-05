using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Repositorios
{
    public class Cliente
    {
        [Key]
        public int Cli_I_Codigo { get; set; }
        [Column(TypeName =("varchar(30)"))]
        public string Cli_V_Nombre_1 { get; set; }
        [Column(TypeName = ("varchar(30)"))]

        public string Cli_V_Nombre_2 { get; set; }
        [Column(TypeName = ("varchar(30)"))]

        public string Cli_V_Apellido_1 { get; set; }
        [Column(TypeName = ("varchar(30)"))]

        public string Cli_V_Apellido_2 { get; set; }
        [Column(TypeName = ("varchar(30)"))]

        public string Cli_V_CedulaRnc { get; set; }
        [Column(TypeName = ("varchar(30)"))]

        public string Cli_V_email { get; set; }
        [Column(TypeName = ("varchar(30)"))]

        public string Cli_V_Telefono { get; set; }
        [Column(TypeName = ("varchar(30)"))]
        public int Pro_I_Codigo { get; set; }
        [ForeignKey("Pro_I_Codigo")]
        public virtual ICollection<Proyecto> Proyectos{ get; set; }

    }
}

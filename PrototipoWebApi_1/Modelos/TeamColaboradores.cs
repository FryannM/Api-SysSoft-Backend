using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrototipoWebApi_1.Modelos
{
    public class TeamColaboradores
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Col_I_Codigo { get; set; }
        public virtual Team  Team { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public DateTime Fecha { get; set; }
        public char Estado { get; set; }
    }
}

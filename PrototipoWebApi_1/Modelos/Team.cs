using System;
using System.ComponentModel.DataAnnotations;

namespace PrototipoWebApi_1.Modelos
{
    public class Team
    {
        [Key]
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CantidadIntegrantes { get; set; }
        public int  Pro_I_Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
	    public char Estado { get; set; }
        public virtual Proyecto Proyecto { get; set; }



    }
}

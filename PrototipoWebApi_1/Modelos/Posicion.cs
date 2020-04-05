using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Modelos
{
    public class Posicion
    {
        [Key]
        public int Pos_I_Codigo { get; set; }
        public string Pos_V_Descripcion { get; set; }
    }
}

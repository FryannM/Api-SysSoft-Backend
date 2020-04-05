using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Modelos
{
    public class Team
    {
        [Key]
        public int Codigo { get; set; }
        public int Descripcion { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototipoWebApi_1.Dtos
{
    public class ColaboradorDto
    {
        //public int Codigo { get; set; }
        public string Name { get; set; }
        public string MidName { get; set; }
        public string Sexo { get; set; }
        public string Fechanacimiendo { get; set; }
        public DepartamentoDto Departamento { get; set; }
        //public string Apellido_1 { get; set; }
        //public string Apellido_2 { get; set; }
        //public char sexo { get; set; }
        //public DateTime FechaNacimiento { get; set; }
        //public string Departamento { get; set; }
        //public string Posicion { get; set; }
        //public string Estado { get; set; }
    }
}

using System;
using System.Text;

namespace PrototipoWebApi_1.Dtos
{
    public class ColaboradoresDto
    {
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public char Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Departamentos { get; set; }
        public string Pocisiones { get; set; }
        public char Estado { get; set; }

    }
}

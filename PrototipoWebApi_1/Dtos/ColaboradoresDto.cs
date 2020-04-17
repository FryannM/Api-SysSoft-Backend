using System;
using System.Text;

namespace PrototipoWebApi_1.Dtos
{
    public class ColaboradoresDto
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

        public char Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Departamento  { get; set; }
        public string Pocisiones { get; set; }
        public char Estado { get; set; }

    }
}

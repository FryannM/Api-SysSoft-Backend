using System;
namespace PrototipoWebApi_1.Dtos
{
    public class ColaboradoresSaveDto
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public char Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Departamento { get; set; }
        public int Pocisiones { get; set; }
        public char Estado { get; set; }
    }
}

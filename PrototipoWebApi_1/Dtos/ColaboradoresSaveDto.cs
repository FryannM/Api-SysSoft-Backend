using System;
namespace PrototipoWebApi_1.Dtos
{
    public class ColaboradoresSaveDto
    {
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombre_1 { get; set; }
        public string Nombre_2 { get; set; }
        public string Apellido_1 { get; set; }
        public string Apellido_2 { get; set; }
        public char Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Departamentos { get; set; }
        public int Pocisiones { get; set; }
        public char Estado { get; set; }
    }
}

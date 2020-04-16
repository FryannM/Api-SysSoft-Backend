using System;
namespace PrototipoWebApi_1.Dtos
{
    public class ProyectoSafeDto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
        public char Estado { get; set; }
    }
}

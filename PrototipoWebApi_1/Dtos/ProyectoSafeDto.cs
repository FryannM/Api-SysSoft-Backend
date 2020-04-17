using System;
namespace PrototipoWebApi_1.Dtos
{
    public class ProyectoSafeDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public char Estado { get; set; }
    }
}

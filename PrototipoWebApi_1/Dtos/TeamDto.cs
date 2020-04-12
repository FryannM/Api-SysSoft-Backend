using System;
namespace PrototipoWebApi_1.Dtos
{
    public class TeamDto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CantidadIntegrantes { get; set; }
        public DateTime FechaCreacion { get; set; }
        public char Estado { get; set; }
        public string Proyecto { get; set; }
    }
}

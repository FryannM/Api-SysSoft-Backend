using System;
namespace PrototipoWebApi_1.Dtos
{
    public class TeamSaveDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CantidadIntegrantes { get; set; }
        public int Proyecto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public char Estado { get; set; }
    }
}

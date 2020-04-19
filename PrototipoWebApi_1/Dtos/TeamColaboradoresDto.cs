using System;
namespace PrototipoWebApi_1.Dtos
{
    public class TeamColaboradoresDto
    {
        public int Id { get; set; }
        public string Team { get; set; }
        public string Colaborador { get; set; }
        public DateTime Fecha { get; set; }
        public char Estado { get; set; }
    }
}

using System;
namespace PrototipoWebApi_1.Dtos
{
    public class TeamColaboradoresSave
    {
        public int Id { get; set; }
        public int TeamCodigo { get; set; }
        public int ColaboradorCodigo { get; set; }
        public DateTime Fecha { get; set; }
        public char Estado { get; set; }
    }
}

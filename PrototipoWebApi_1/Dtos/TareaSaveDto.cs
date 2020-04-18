using System;
namespace PrototipoWebApi_1.Dtos
{
    public class TareaSaveDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Usuario { get; set; }
        public int Proyecto { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }
}

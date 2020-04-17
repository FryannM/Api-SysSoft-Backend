using System;
namespace PrototipoWebApi_1.Dtos
{
    public class TareasDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Usuario  { get; set; }
        public string Proyecto { get; set; }
        public char Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }
}

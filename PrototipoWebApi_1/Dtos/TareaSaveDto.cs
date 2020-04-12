using System;
namespace PrototipoWebApi_1.Dtos
{
    public class TareaSaveDto
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoProyecto { get; set; }
        public char Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
    }
}

using System;
namespace PrototipoWebApi_1.Dtos
{
    public class UsuarioDto
    {


        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public char Estado { get; set; }

    }
}

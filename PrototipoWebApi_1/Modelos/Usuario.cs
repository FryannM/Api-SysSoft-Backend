using System;
namespace PrototipoWebApi_1.Modelos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario  { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
    }
}

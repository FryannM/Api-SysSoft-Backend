using System;
namespace PrototipoWebApi_1.Modelos
{
    public class UsuarioApi
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; } = "access-token-8f3ae836da744329a6f93bf20594b5cc";
        public int Pos_I_Codigo { get; set; }
        public virtual Posicion Cargo { get; set; }
        public char Estado { get; set; }


    }
}

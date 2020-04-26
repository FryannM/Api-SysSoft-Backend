using System;
namespace PrototipoWebApi_1.Dtos
{
    public class UsuarioSaveDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public int Cargo { get; set; }
        public char Estado { get; set; }
        public string AccessToken { get; set; }

    }
}

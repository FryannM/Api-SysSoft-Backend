namespace PrototipoWebApi_1.Dtos
{
    public class UsuarioLoginList
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; } = "access-token-";
    }
}

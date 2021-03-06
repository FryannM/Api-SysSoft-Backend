﻿using System;
namespace PrototipoWebApi_1.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; } = "access-token-";
        public string Cargo { get; set; }
        public char Estado { get; set; }

    }
}

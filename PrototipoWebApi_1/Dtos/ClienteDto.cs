﻿using System;
namespace PrototipoWebApi_1.Dtos
{
    public class ClienteDto
    {
        
        public int Id { get; set; }

        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }


        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }


        public string CedulaRnc { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public string Proyecto { get; set; }
        public int ProyectoCodigo { get; set; }

        public char Estado { get; set; }


    }
}

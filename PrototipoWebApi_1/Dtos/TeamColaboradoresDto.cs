using System;
using System.Collections.Generic;

namespace PrototipoWebApi_1.Dtos
{
    public class TeamColaboradoresDto
    {

        public TeamColaboradoresDto()
        {
        }
            public int Id { get; set; }
            public string Team { get; set; }
        public int CodigoTeam { get; set; }

        public string Colaborador { get; set; }
            public DateTime Fecha { get; set; }
            public char Estado { get; set; }
    }
}

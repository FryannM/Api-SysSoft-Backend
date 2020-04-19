using System;
namespace PrototipoWebApi_1.Modelos
{
    public class TeamColaboradores
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public Team Team { get; set; }
        public int Col_I_Codigo { get; set; }
        public Colaborador Colaborador { get; set; }
        public DateTime Fecha { get; set; }
        public char Estado { get; set; }
    }
}

using System;
namespace PrototipoWebApi_1.Dtos
{
    public class PosicionDtoSave
    {
        public int  Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public decimal Sueldo { get; set; }
        public string Perfil { get; set; }
    }
}

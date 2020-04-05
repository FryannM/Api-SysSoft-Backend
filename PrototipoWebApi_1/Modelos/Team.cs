using System.ComponentModel.DataAnnotations;

namespace PrototipoWebApi_1.Modelos
{
    public class Team
    {
        [Key]
        public int Codigo { get; set; }
        public int Descripcion { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototipoWebApi_1.Repositorios
{
    public class Proyecto
    {
        [Key]
        public int Pro_I_Codigo { get; set; }
        [Column(TypeName =("varchar(60)"))]
        public string Pro_V_Descripcion { get; set; }
       
    }
}
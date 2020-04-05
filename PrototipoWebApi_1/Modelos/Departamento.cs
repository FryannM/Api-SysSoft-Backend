using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrototipoWebApi_1.Modelos
{
    public class Departamento
    {
        [Key]
        public virtual  int Dep_I_Codigo { get; set; }
        [Column(TypeName = "varchar(30)")]
        public virtual string Dep_V_Descripcion { get; set; }
    }
}
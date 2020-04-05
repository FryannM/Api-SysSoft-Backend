using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PrototipoWebApi_1.Modelos
{
    public class Departamento
    {
        [Key]
        [JsonProperty(PropertyName = "Codigo")]
        public virtual  int Dep_I_Codigo { get; set; }
        [JsonProperty(PropertyName = "Descripcion")]
        [Column(TypeName = "varchar(30)")]
        public virtual string Dep_V_Descripcion { get; set; }
    }
}
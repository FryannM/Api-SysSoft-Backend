using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PrototipoWebApi_1.Modelos
{
    public class Departamento
    {
        [Key]
        [JsonProperty(PropertyName = "codigo")]
        public virtual  int Dep_I_Codigo { get; set; }
        [JsonProperty(PropertyName = "descripcion")]
        [Column(TypeName = "varchar(30)")]
        public virtual string Dep_V_Descripcion { get; set; }
        public virtual string Nombre { get; set; }
        public virtual char Estado { get; set; }





    }
}
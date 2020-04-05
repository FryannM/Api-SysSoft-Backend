using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    public class Proyecto
    {
        [Key]

        [JsonProperty(PropertyName = "Codigo")]
        public int Pro_I_Codigo { get; set; }
        [Column(TypeName =("varchar(60)"))]
        [JsonProperty(PropertyName = "Descripcion")]
        public string Pro_V_Descripcion { get; set; }
    }
}
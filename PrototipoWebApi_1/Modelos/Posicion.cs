using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    public class Posicion
    {
        [Key]
        [JsonProperty(PropertyName = "Codigo")]
        public int Pos_I_Codigo { get; set; }
        [JsonProperty(PropertyName = "Descripcion")]
        public string Pos_V_Descripcion { get; set; }
    }
}

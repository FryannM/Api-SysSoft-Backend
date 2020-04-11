using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    public class Posicion
    {
        [Key]
        [JsonProperty(PropertyName = "codigo")]
        public int Pos_I_Codigo { get; set; }
        [JsonProperty(PropertyName = "descripcion")]
        public string Pos_V_Descripcion { get; set; }
        public string Estado { get; set; }
        public decimal Sueldo { get; set; }
        public string Perfil { get; set; }


    }
}

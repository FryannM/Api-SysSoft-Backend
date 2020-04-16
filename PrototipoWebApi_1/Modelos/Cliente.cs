using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    public class Cliente
    {
        [Key]
        [JsonProperty(PropertyName = "codigo")]
        public int Cli_I_Codigo { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Cli_V_Nombre_1 { get; set; }

        [JsonProperty(PropertyName = "nombre2")]
        public string Cli_V_Nombre_2 { get; set; }

        [JsonProperty(PropertyName = "apellido")]
        public string Cli_V_Apellido_1 { get; set; }

        [JsonProperty(PropertyName = "apellido2")]
        public string Cli_V_Apellido_2 { get; set; }

        [JsonProperty(PropertyName = "cedulaORnc")]
        public string Cli_V_CedulaRnc { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Cli_V_email { get; set; }

        [JsonProperty(PropertyName = "telefono")]
        public string Cli_V_Telefono { get; set; }

        [JsonProperty(PropertyName = "proyectoCodigo")]
        public int Pro_I_Codigo { get; set; }

        public virtual Proyecto Proyecto { get; set; }

        public char Estado { get; set; }

    }
}

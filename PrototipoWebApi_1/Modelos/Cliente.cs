using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    public class Cliente
    {
        [Key]
        [JsonProperty(PropertyName = "Codigo")]
        public int Cli_I_Codigo { get; set; }

        [JsonProperty(PropertyName = "Nombre")]
        public string Cli_V_Nombre_1 { get; set; }

        [JsonProperty(PropertyName = "Nombre2")]
        public string Cli_V_Nombre_2 { get; set; }

        [JsonProperty(PropertyName = "Apellido")]
        public string Cli_V_Apellido_1 { get; set; }


        [JsonProperty(PropertyName = "Apellido2")]
        public string Cli_V_Apellido_2 { get; set; }

        [JsonProperty(PropertyName = "CedulaORnc")]
        public string Cli_V_CedulaRnc { get; set; }

        [JsonProperty(PropertyName = "Email")]
        public string Cli_V_email { get; set; }

        [JsonProperty(PropertyName = "Telefono")]
        public string Cli_V_Telefono { get; set; }

        [JsonProperty(PropertyName = "ProyectoCodigo")]
        public int Pro_I_Codigo { get; set; }

    }
}

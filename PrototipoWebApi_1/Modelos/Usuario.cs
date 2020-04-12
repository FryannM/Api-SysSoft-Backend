using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    [Owned]
    public class Usuario
    {
        [Key]
        [JsonProperty(PropertyName = "Codigo")]
        public int Usr_I_CodigoUsuario { get; set; }
        [JsonProperty(PropertyName = "Nombre")]
        public string Usr_V_Nombre { get; set; }
        [JsonProperty(PropertyName = "Usuario")]
        public string Usr_V_NombreUsuario  { get; set; }
        [JsonProperty(PropertyName = "Password")]
        public string Usr_V_PassWord { get; set; }
        [JsonProperty(PropertyName = "Email")]
        public string Usr_V_Email { get; set; }
        [JsonProperty(PropertyName = "Cargo")]
        public int Pos_I_Codigo { get; set; }
        public virtual Posicion Cargo { get; set; }

    }
}

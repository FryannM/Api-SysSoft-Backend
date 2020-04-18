using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    public class Errores
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int Codigo { get; set; }
        public string Mensaje { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
     //   public  virtual Usuario Usuario { get; set; }
        public int Usr_I_CodigoUsuario { get; set; }
      

    }
}

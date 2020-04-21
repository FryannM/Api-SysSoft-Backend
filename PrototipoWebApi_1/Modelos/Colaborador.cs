using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace PrototipoWebApi_1.Modelos
{
    public class Colaborador
    {

        [Key]
        [JsonProperty(PropertyName = "Codigo")]
        public int Col_I_Codigo { get; set; }
        [Column(TypeName = "varchar(20)")]
        [JsonProperty(PropertyName = "Cedula")]
        public string Col_V_Cedula { get; set; }
        [Column(TypeName = "varchar(11)")]


        [JsonProperty(PropertyName = "Nombre")]
        public string Col_V_Nombre_1 { get; set; }
        [Column(TypeName = "varchar(20)")]

        [JsonProperty(PropertyName = "Nombre2")]
        public string Col_V_Nombre_2 { get; set; }
        [Column(TypeName = "varchar(20)")]


        [JsonProperty(PropertyName = "Apellido")]
        public string Col_V_Apellido_1 { get; set; }
        [Column(TypeName = "varchar(20)")]

        [JsonProperty(PropertyName = "Apellido2")]
        public string Col_V_Apellido_2 { get; set; }
        [Column(TypeName = "char(1)")]

        [JsonProperty(PropertyName = "Sexo")]
        public char Col_C_Sexo { get; set; }

        [JsonProperty(PropertyName = "FechaNacimiento")]
        public DateTime Col_D_Fecha_Nacimiento { get; set; }
        [JsonProperty(PropertyName = "Departamento")]


        public int Dep_I_Codigo { get; set; }
        public virtual Departamento Departamentos { get; set; }
        public int Pos_I_Codigo { get; set; }
        public virtual Posicion Pocisiones { get; set; }

        public char Col_B_Estado { get; set; }

    }
}

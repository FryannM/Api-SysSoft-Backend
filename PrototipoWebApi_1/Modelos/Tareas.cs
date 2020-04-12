using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PrototipoWebApi_1.Modelos
{

	public class Tareas
	{
		[Key]

		public int Codigo { get; set; }
		public string Titulo { get; set; }
		public int Usr_I_CodigoUsuario { get; set; }
		public DateTime FechaCreacion { get; set; }
		public char Estado { get; set; }
		public int Pro_I_Codigo { get; set; }
		public string Comentario { get; set; }
		public virtual Usuario Usuario { get; set; }
		public virtual Proyecto Proyecto { get; set; }
	}
}

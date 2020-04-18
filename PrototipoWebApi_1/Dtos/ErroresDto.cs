using System;
namespace PrototipoWebApi_1.Dtos
{
    public class ErroresDto
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Usuario { get; set; }
 
    }
}

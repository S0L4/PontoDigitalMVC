using System;

namespace PontoDigitalMVC.Models
{
    public class ComentarioModel
    {
        public int Id { get; set;}
        public UsuarioModel Usuario { get; set;}
        public string Texto { get; set;}
        public DateTime DataCriacao { get; set;}        
        public string Status { get; set;}
    }
}
using System.Collections.Generic;
using PontoDigitalMVC.Models;

namespace PontoDigitalMVC.ViewModel
{
    public class ListasViewModel
    {
        public List<ComentarioModel> Comentarios { get; set;}
        public List<UsuarioModel> Usuarios { get; set;}
        
        public ListasViewModel(List<ComentarioModel> comentarios, List<UsuarioModel> usuarios)
        {
            Comentarios = comentarios;
            Usuarios = usuarios;
        }

        public ListasViewModel()
        {
        }
    }
}
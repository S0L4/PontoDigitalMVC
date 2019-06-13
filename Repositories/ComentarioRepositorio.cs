using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalMVC.Models;

namespace PontoDigitalMVC.Repositories
{
    public class ComentarioRepositorio
    {
        public List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();
        
        public const string PATH = "Databases/Comentarios.csv";

        public void InserirComentario(ComentarioModel comentario)
        {
            if (File.Exists(PATH))
            {
                comentario.Id = File.ReadAllLines(PATH).Length + 1;
            } else {
                comentario.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{comentario.Id};{comentario.Usuario.Nome};{comentario.Texto};{DateTime.Now};{comentario.Status}");
            sw.Close();
        }   

        public List<ComentarioModel> ListaDeComentarios()
        {
            string[] comentarios = File.ReadAllLines(PATH);

            foreach (var item in comentarios)
            {
                if (item != null)
                {
                    string[] dados = item.Split(";");
                    var comentario = new ComentarioModel();

                        comentario.Id = int.Parse(dados[0]);
                        comentario.Usuario = new UsuarioModel();
                        comentario.Usuario.Nome = dados[1];
                        comentario.Texto = dados[2];
                        comentario.DataCriacao = DateTime.Parse(dados[3]);
                        comentario.Status = dados[4];

                        listaDeComentarios.Add(comentario);
                    continue;    
                }
            }
            return listaDeComentarios;
        }

        public ComentarioModel BuscarId(int id)
        {
            listaDeComentarios = ListaDeComentarios();

            foreach (var item in listaDeComentarios)
            {
                if (id == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Aprovar(int id)
        {
            string[] comentarios = File.ReadAllLines(PATH);

            for (int i = 0; i < comentarios.Length; i++)
            {
                string[] dados = comentarios[i].Split(";");
                if (id.ToString() == dados[0])
                {
                    comentarios[i] = ($"{dados[0]};{dados[1]};{dados[2]};{dados[3]};{true}");
                    break;
                }
            }
            File.WriteAllLines(PATH, comentarios);
        }

        public void Rejeitar(int id)
        {
            string[] comentarios = File.ReadAllLines(PATH);

            for (int i = 0; i < comentarios.Length; i++)
            {
                string[] dados = comentarios[i].Split(";");
                if (id.ToString() == dados[0])
                {
                    comentarios[i] = "";
                    break;
                }
            }
            File.WriteAllLines(PATH, comentarios);
        }
    }
}
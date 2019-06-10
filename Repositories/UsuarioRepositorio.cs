using System;
using System.Collections.Generic;
using System.IO;
using PontoDigitalMVC.Models;

namespace PontoDigitalMVC.Repositories
{
    public class UsuarioRepositorio 
    {
        public List<UsuarioModel> listaDeUsuarios =  new List<UsuarioModel>();

        public const string PATH = "DataBases/Usuarios.csv";

        public void InserirUsuario(UsuarioModel cadastro)
        {
            if (File.Exists(PATH))
            {
                cadastro.Id = File.ReadAllLines(PATH).Length + 1;
            } else {
                cadastro.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);

            sw.WriteLine($"{cadastro.Id};{cadastro.Nome};{cadastro.Email};{cadastro.Senha};{cadastro.DataNascimento}");
            sw.Close();
        }

        public List<UsuarioModel> ListaDeUsuarios()
        {
            string[] cadastros = File.ReadAllLines(PATH);

            foreach (var item in cadastros)
            {
                if(item != null)
                {
                    string[] dados = item.Split(";");
                    var usuario = new UsuarioModel();

                        usuario.Id = int.Parse(dados[0]); 
                        usuario.Nome = dados[1];
                        usuario.Email = dados[2];
                        usuario.Senha = dados[3];
                        usuario.DataNascimento = DateTime.Parse(dados[4]);

                        listaDeUsuarios.Add(usuario);
                    continue;
                }
            }
            return listaDeUsuarios;    
        }      
    }
}
using System.Collections.Generic;
using System.IO;
using PontoDigitalMVC.Models;

namespace PontoDigitalMVC.Repositories
{
    public class UsuarioRepositorio 
    {
        public List<UsuarioModel> listaDeUsuarios =  new List<UsuarioModel>();

        public const string PATH = "DataBases/Registros.csv";

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
    }
}
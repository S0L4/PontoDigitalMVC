using System.Collections.Generic;
using System.IO;
using PontoDigitalMVC.Models;

namespace PontoDigitalMVC.Repositories
{
    public class AdministradorRepositorio
    {
        private List<AdministradorModel> administradores = new List<AdministradorModel>();

        private const string PATH = "DataBases/Administrador.csv";

        public List<AdministradorModel> DadosDoAdministrador()
        {
            var cadastro = File.ReadAllLines(PATH);
            
            foreach (var item in cadastro)
            {
                var dados = item.Split(";");
                AdministradorModel admin = new AdministradorModel();
                
                    admin.Id = int.Parse(dados[0]);
                    admin.NomeAdm = dados[1];
                    admin.EmailAdm = dados[2];
                    admin.SenhaAdm = dados[3];

                    administradores.Add(admin);
            }
            return administradores;
        }
    }
}
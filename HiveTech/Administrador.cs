using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    class Administrador : Cliente
    {
        public string Chave { get; set; }

        public Administrador(string chave, string nome, string email, string senha, string cpf, string dt, int id = 0) : base(nome, email, senha, cpf, dt, id)
        {
            Chave = chave;
        }
    }
        
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HiveTech
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }

    public class ClienteDAO
    {
        public MySqlConnection conexao { get; set; }

        public ClienteDAO() 
        {
            conexao = new MySqlConnection("Server=localhost;Database=HiveTechDB;Uid=root;Pwd=;");
            conexao.Open();
        }

        public void Inserir(Cliente cliente) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO cliente (nome, email, senha) VALUES (@Nome, @Email, @Senha)";
            comando.Parameters.AddWithValue("@Nome",cliente.Nome);
            comando.Parameters.AddWithValue("@Email",cliente.Email);
            comando.Parameters.AddWithValue("@Senha",cliente.Senha);
            comando.ExecuteNonQuery();
        }

        public void Alterar(Cliente cliente) 
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"UPDATE cliente SET nome = @Nome, email = @Email, senha = @Senha WHERE id = @ID";
            comando.Parameters.AddWithValue("@Nome",cliente.Nome);
            comando.Parameters.AddWithValue("@Email",cliente.Email);
            comando.Parameters.AddWithValue("@Senha", cliente.Senha);
            comando.ExecuteNonQuery();
        }

        public void Apagar(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"DELETE FROM cliente WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID",id);
            comando.ExecuteNonQuery();
            
        }
    }
}
